using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using SchoolManagementSystem.Models;
using System.IO;

namespace SchoolManagementSystem
{
    public static class PDFReport
    {
        private static readonly Color ThemeBlue = new Color(5, 61, 136);

        private static void StyleDocument(Document doc)
        {
            doc.Styles["Normal"].Font.Name = "Segoe UI";
            doc.Styles["Normal"].Font.Size = 10;
        }

        private static void AddHeader(Document doc, Section section, string titleText)
        {
            var title = section.AddParagraph(titleText);
            title.Format.Font.Size = 16;
            title.Format.Font.Color = ThemeBlue;
            title.Format.Font.Bold = true;
            title.Format.SpaceAfter = "0.5cm";

            section.AddParagraph($"Generated on: {DateTime.Now}")
                .Format.Font.Size = 9;

            section.AddParagraph(" ");
        }

        public static string GenerateStudentReport(int studentId, bool openAfter = true)
        {
            using (var context = new SchoolContext())
            {
                var student = context.Students.Find(studentId);
                var grades = from g in context.Grades
                             join sc in context.StudentCourses on g.StudentCourseID equals sc.StudentCourseID
                             where sc.StudentID == studentId
                             select new
                             {
                                 sc.Course.CourseName,
                                 g.GradeValue,
                                 g.GradeDate,
                                 g.Notes
                             };

                var doc = new Document();
                var section = doc.AddSection();
                StyleDocument(doc);
                AddHeader(doc, section, $"Student Report: {student.FirstName} {student.LastName}");

                var table = section.AddTable();
                table.Borders.Width = 0.75;
                table.AddColumn("5cm");
                table.AddColumn("2cm");
                table.AddColumn("3cm");
                table.AddColumn("6cm");

                var header = table.AddRow();
                header.Shading.Color = ThemeBlue;
                header.Format.Font.Color = Colors.White;
                header.Format.Font.Bold = true;

                header.Cells[0].AddParagraph("Course");
                header.Cells[1].AddParagraph("Grade");
                header.Cells[2].AddParagraph("Date");
                header.Cells[3].AddParagraph("Notes");

                foreach (var g in grades)
                {
                    var row = table.AddRow();
                    row.Cells[0].AddParagraph(g.CourseName);
                    row.Cells[1].AddParagraph(g.GradeValue.ToString("F2"));
                    row.Cells[2].AddParagraph(g.GradeDate.ToShortDateString());
                    row.Cells[3].AddParagraph(g.Notes);
                }

                section.Footers.Primary.AddParagraph("Page ").AddPageField();

                string fileName = $"StudentReport_{student.FirstName}_{DateTime.Now.Ticks}.pdf";
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

                var renderer = new PdfDocumentRenderer(true) { Document = doc };
                renderer.RenderDocument();
                renderer.PdfDocument.Save(fullPath);

                if (openAfter)
                    Process.Start(fullPath);

                return fullPath;
            }
        }

        public static string GenerateCourseReport(int courseId, bool openAfter = true)
        {
            using (var context = new SchoolContext())
            {
                var course = context.Courses.Find(courseId);
                var grades = from g in context.Grades
                             join sc in context.StudentCourses on g.StudentCourseID equals sc.StudentCourseID
                             where sc.CourseID == courseId
                             select new
                             {
                                 StudentName = sc.Student.FirstName + " " + sc.Student.LastName,
                                 g.GradeValue,
                                 g.GradeDate,
                                 g.Notes
                             };

                var doc = new Document();
                var section = doc.AddSection();
                StyleDocument(doc);
                AddHeader(doc, section, $"Course Report: {course.CourseName}");

                var table = section.AddTable();
                table.Borders.Width = 0.75;
                table.AddColumn("5cm");
                table.AddColumn("2cm");
                table.AddColumn("3cm");
                table.AddColumn("6cm");

                var header = table.AddRow();
                header.Shading.Color = ThemeBlue;
                header.Format.Font.Color = Colors.White;
                header.Format.Font.Bold = true;

                header.Cells[0].AddParagraph("Student");
                header.Cells[1].AddParagraph("Grade");
                header.Cells[2].AddParagraph("Date");
                header.Cells[3].AddParagraph("Notes");

                decimal total = 0;
                int count = 0;

                foreach (var g in grades)
                {
                    var row = table.AddRow();
                    row.Cells[0].AddParagraph(g.StudentName);
                    row.Cells[1].AddParagraph(g.GradeValue.ToString("F2"));
                    row.Cells[2].AddParagraph(g.GradeDate.ToShortDateString());
                    row.Cells[3].AddParagraph(g.Notes);
                    total += g.GradeValue;
                    count++;
                }

                section.AddParagraph(" ");
                if (count > 0)
                {
                    decimal avg = total / count;
                    var avgPara = section.AddParagraph($"Class Average: {avg:F2}");
                    avgPara.Format.Font.Bold = true;
                }

                section.Footers.Primary.AddParagraph("Page ").AddPageField();

                string fileName = $"CourseReport_{course.CourseName}_{DateTime.Now.Ticks}.pdf";
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

                var renderer = new PdfDocumentRenderer(true) { Document = doc };
                renderer.RenderDocument();
                renderer.PdfDocument.Save(fullPath);

                if (openAfter)
                    Process.Start(fullPath);

                return fullPath;
            }
        }
    }
}
