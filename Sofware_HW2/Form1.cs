using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Sofware_HW2
{
    public partial class Form1 : Form
    {

        private void LoadSetting()
        {
            try
            {
                RegistryKey subKey = Registry.LocalMachine.OpenSubKey("Software\\NotePad");

                string fname = subKey.GetValue("FontName").ToString();
                Single fsize = Convert.ToSingle(subKey.GetValue("FontSize"));

                textBox1.Font = new System.Drawing.Font(fname, fsize);

                int color;
                color = Convert.ToInt32(subKey.GetValue("ForeColor"));
                textBox1.ForeColor = System.Drawing.Color.FromArgb(color);

                color = Convert.ToInt32(subKey.GetValue("BackColor"));
                textBox1.BackColor = System.Drawing.Color.FromArgb(color);
            }

            catch
            {

            }
        }
        
        private void SaveSetting()
        {
            try
            {
                RegistryKey rk = Registry.LocalMachine.OpenSubKey("Software", true);
                RegistryKey newkey = rk.CreateSubKey("NotePad");

                //글꼴 스타일 저장
                newkey.SetValue("FontName", textBox1.Font.FontFamily.GetName(0));
                newkey.SetValue("FontSize", Convert.ToString(textBox1.Font.Size));

                //글꼴 색과 바탕색 지정
                newkey.SetValue("ForeColor", Convert.ToString(textBox1.ForeColor.ToArgb()));
                newkey.SetValue("BackColor", Convert.ToString(textBox1.ForeColor.ToArgb()));
            }
            catch
            {

            }
        }
        public Form1()
        {
            InitializeComponent();
            LoadSetting();
        }

        private void Form1_Closing()
        {
            SaveSetting();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //스트림 열기
                Stream strm = openFileDialog1.OpenFile();
                StreamReader reader = new StreamReader(strm);

                //텍스트 내용 읽어오기
                textBox1.Text = reader.ReadToEnd();

                //스트림 닫기
                reader.Close();
                strm.Close();

                //파일 이름 저장
                this.Text = openFileDialog1.FileName;
            }
        }
        private void miSave_Click(object sender, EventArgs e)
        {
            //현재 작업중인 파일 이름을 구해서 파일을 저장합니다.
            string fname = this.Text;

            //파일 이름으로 스트림 열기
            StreamWriter writer = new StreamWriter(fname);

            //텍스트 내용 저장하기
            writer.Write(textBox1.Text);

            //스트림 닫기
            writer.Close();
        }

        private void 다른이름으로저장AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fname = saveFileDialog1.FileName;

                //파일 이름으로 스트림 열기
                StreamWriter writer = new StreamWriter(fname);

                //텍스트 내용을 저장합니다.
                writer.Write(textBox1.Text);

                //스트림 닫기
                writer.Close();

                //파일 이름 저장
                this.Text = fname;
            }
        }

        private void 실행취소UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void 오려내기TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void 복사하기CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void 붙여넣기PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void 지우기DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
        }

        private void 모두선택AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void 자동줄바꿈WToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.WordWrap)
            {
                textBox1.WordWrap = false;
                자동줄바꿈WToolStripMenuItem.Checked = false;
            }
            else
            {
                textBox1.WordWrap = true;
                자동줄바꿈WToolStripMenuItem.Checked = true;
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void 글꼴FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                textBox1.Font = fontDialog1.Font;
        }

        private void 글자색바꾸기CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                textBox1.ForeColor = colorDialog1.Color;
        }

        private void 바탕색바꾸기BToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("메모장 테스트 버젼 0.1");
        }
    }
}
