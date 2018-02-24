namespace Sofware_HW2
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새파일NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miSave = new System.Windows.Forms.ToolStripMenuItem();
            this.다른이름으로저장AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.끝내기XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.실행취소UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.오려내기TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.복사하기CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.붙여넣기PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.지우기DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.모두선택AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보기VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.자동줄바꿈WToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.글꼴FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.글자색바꾸기CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.바탕색바꾸기BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.편집ToolStripMenuItem,
            this.보기VToolStripMenuItem,
            this.도움말HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(435, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새파일NToolStripMenuItem,
            this.miOpen,
            this.miSave,
            this.다른이름으로저장AToolStripMenuItem,
            this.toolStripMenuItem1,
            this.끝내기XToolStripMenuItem});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.파일FToolStripMenuItem.Text = "파일(F)";
            // 
            // 새파일NToolStripMenuItem
            // 
            this.새파일NToolStripMenuItem.Name = "새파일NToolStripMenuItem";
            this.새파일NToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.새파일NToolStripMenuItem.Text = "새 파일(N)";
            // 
            // miOpen
            // 
            this.miOpen.Name = "miOpen";
            this.miOpen.Size = new System.Drawing.Size(234, 26);
            this.miOpen.Text = "열기(O)";
            this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
            // 
            // miSave
            // 
            this.miSave.Name = "miSave";
            this.miSave.Size = new System.Drawing.Size(234, 26);
            this.miSave.Text = "저장(S)";
            this.miSave.Click += new System.EventHandler(this.miSave_Click);
            // 
            // 다른이름으로저장AToolStripMenuItem
            // 
            this.다른이름으로저장AToolStripMenuItem.Name = "다른이름으로저장AToolStripMenuItem";
            this.다른이름으로저장AToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.다른이름으로저장AToolStripMenuItem.Text = "다른 이름으로 저장(A)";
            this.다른이름으로저장AToolStripMenuItem.Click += new System.EventHandler(this.다른이름으로저장AToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(231, 6);
            // 
            // 끝내기XToolStripMenuItem
            // 
            this.끝내기XToolStripMenuItem.Name = "끝내기XToolStripMenuItem";
            this.끝내기XToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.끝내기XToolStripMenuItem.Text = "끝내기(X)";
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.실행취소UToolStripMenuItem,
            this.toolStripMenuItem2,
            this.오려내기TToolStripMenuItem,
            this.복사하기CToolStripMenuItem,
            this.붙여넣기PToolStripMenuItem,
            this.지우기DToolStripMenuItem,
            this.toolStripMenuItem3,
            this.모두선택AToolStripMenuItem});
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            this.편집ToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.편집ToolStripMenuItem.Text = "편집(E)";
            // 
            // 실행취소UToolStripMenuItem
            // 
            this.실행취소UToolStripMenuItem.Name = "실행취소UToolStripMenuItem";
            this.실행취소UToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.실행취소UToolStripMenuItem.Text = "실행 취소(U)";
            this.실행취소UToolStripMenuItem.Click += new System.EventHandler(this.실행취소UToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(167, 6);
            // 
            // 오려내기TToolStripMenuItem
            // 
            this.오려내기TToolStripMenuItem.Name = "오려내기TToolStripMenuItem";
            this.오려내기TToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.오려내기TToolStripMenuItem.Text = "오려내기(T)";
            this.오려내기TToolStripMenuItem.Click += new System.EventHandler(this.오려내기TToolStripMenuItem_Click);
            // 
            // 복사하기CToolStripMenuItem
            // 
            this.복사하기CToolStripMenuItem.Name = "복사하기CToolStripMenuItem";
            this.복사하기CToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.복사하기CToolStripMenuItem.Text = "복사하기(C)";
            this.복사하기CToolStripMenuItem.Click += new System.EventHandler(this.복사하기CToolStripMenuItem_Click);
            // 
            // 붙여넣기PToolStripMenuItem
            // 
            this.붙여넣기PToolStripMenuItem.Name = "붙여넣기PToolStripMenuItem";
            this.붙여넣기PToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.붙여넣기PToolStripMenuItem.Text = "붙여넣기(P)";
            this.붙여넣기PToolStripMenuItem.Click += new System.EventHandler(this.붙여넣기PToolStripMenuItem_Click);
            // 
            // 지우기DToolStripMenuItem
            // 
            this.지우기DToolStripMenuItem.Name = "지우기DToolStripMenuItem";
            this.지우기DToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.지우기DToolStripMenuItem.Text = "지우기(D)";
            this.지우기DToolStripMenuItem.Click += new System.EventHandler(this.지우기DToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(167, 6);
            // 
            // 모두선택AToolStripMenuItem
            // 
            this.모두선택AToolStripMenuItem.Name = "모두선택AToolStripMenuItem";
            this.모두선택AToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.모두선택AToolStripMenuItem.Text = "모두 선택(A)";
            this.모두선택AToolStripMenuItem.Click += new System.EventHandler(this.모두선택AToolStripMenuItem_Click);
            // 
            // 보기VToolStripMenuItem
            // 
            this.보기VToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.자동줄바꿈WToolStripMenuItem,
            this.글꼴FToolStripMenuItem,
            this.toolStripMenuItem4,
            this.글자색바꾸기CToolStripMenuItem,
            this.바탕색바꾸기BToolStripMenuItem});
            this.보기VToolStripMenuItem.Name = "보기VToolStripMenuItem";
            this.보기VToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.보기VToolStripMenuItem.Text = "보기(V)";
            // 
            // 자동줄바꿈WToolStripMenuItem
            // 
            this.자동줄바꿈WToolStripMenuItem.Name = "자동줄바꿈WToolStripMenuItem";
            this.자동줄바꿈WToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.자동줄바꿈WToolStripMenuItem.Text = "자동 줄 바꿈(W)";
            this.자동줄바꿈WToolStripMenuItem.Click += new System.EventHandler(this.자동줄바꿈WToolStripMenuItem_Click);
            // 
            // 글꼴FToolStripMenuItem
            // 
            this.글꼴FToolStripMenuItem.Name = "글꼴FToolStripMenuItem";
            this.글꼴FToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.글꼴FToolStripMenuItem.Text = "글꼴(F)";
            this.글꼴FToolStripMenuItem.Click += new System.EventHandler(this.글꼴FToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(196, 6);
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // 글자색바꾸기CToolStripMenuItem
            // 
            this.글자색바꾸기CToolStripMenuItem.Name = "글자색바꾸기CToolStripMenuItem";
            this.글자색바꾸기CToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.글자색바꾸기CToolStripMenuItem.Text = "글자색 바꾸기(C)";
            this.글자색바꾸기CToolStripMenuItem.Click += new System.EventHandler(this.글자색바꾸기CToolStripMenuItem_Click);
            // 
            // 바탕색바꾸기BToolStripMenuItem
            // 
            this.바탕색바꾸기BToolStripMenuItem.Name = "바탕색바꾸기BToolStripMenuItem";
            this.바탕색바꾸기BToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.바탕색바꾸기BToolStripMenuItem.Text = "바탕색 바꾸기(B)";
            this.바탕색바꾸기BToolStripMenuItem.Click += new System.EventHandler(this.바탕색바꾸기BToolStripMenuItem_Click);
            // 
            // 도움말HToolStripMenuItem
            // 
            this.도움말HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.정보ToolStripMenuItem});
            this.도움말HToolStripMenuItem.Name = "도움말HToolStripMenuItem";
            this.도움말HToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.도움말HToolStripMenuItem.Text = "도움말(H)";
            // 
            // 정보ToolStripMenuItem
            // 
            this.정보ToolStripMenuItem.Name = "정보ToolStripMenuItem";
            this.정보ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.정보ToolStripMenuItem.Text = "정보";
            this.정보ToolStripMenuItem.Click += new System.EventHandler(this.정보ToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(435, 306);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 334);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 보기VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말HToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem 새파일NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miOpen;
        private System.Windows.Forms.ToolStripMenuItem miSave;
        private System.Windows.Forms.ToolStripMenuItem 다른이름으로저장AToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 끝내기XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 실행취소UToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 오려내기TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 복사하기CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 붙여넣기PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 지우기DToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 모두선택AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 자동줄바꿈WToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 글꼴FToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem 글자색바꾸기CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 바탕색바꾸기BToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 정보ToolStripMenuItem;
    }
}

