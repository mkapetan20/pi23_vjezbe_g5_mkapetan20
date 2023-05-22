using Evaluation_Manager.Models;
using Evaluation_Manager.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_Manager {
    public partial class FrmFinalReport : Form {
        public FrmFinalReport() {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }

        private List<StudentReportView> GenerateStudentReport() {
            var allStudents = StudentRepository.GetStudents();
            var examReport = new List<StudentReportView>();

            foreach (var student in allStudents) {

                if (student.HasSignature() == true) {
                    var examReports = new StudentReportView(student);
                    examReports.Add(examReport);

                }
            }
            return GenerateStudentReport();
        }


        private void btnGenerateReport_Click(object sender, EventArgs e) {
            var form = new FrmFinalReport();
            form.ShowDialog();  

        }
    }
}
