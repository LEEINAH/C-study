namespace WindowsFormsApp5
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
			this.listHand = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textName = new System.Windows.Forms.TextBox();
			this.buttonStart = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textProgress = new System.Windows.Forms.TextBox();
			this.textBooks = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.buttonAsk = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listHand
			// 
			this.listHand.FormattingEnabled = true;
			this.listHand.Location = new System.Drawing.Point(379, 27);
			this.listHand.Name = "listHand";
			this.listHand.Size = new System.Drawing.Size(166, 459);
			this.listHand.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(379, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Your hand";
			// 
			// textName
			// 
			this.textName.Location = new System.Drawing.Point(13, 29);
			this.textName.Name = "textName";
			this.textName.Size = new System.Drawing.Size(169, 20);
			this.textName.TabIndex = 2;
			// 
			// buttonStart
			// 
			this.buttonStart.Location = new System.Drawing.Point(190, 27);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(183, 23);
			this.buttonStart.TabIndex = 3;
			this.buttonStart.Text = "Start the game!";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Your name";
			// 
			// textProgress
			// 
			this.textProgress.Location = new System.Drawing.Point(13, 74);
			this.textProgress.Multiline = true;
			this.textProgress.Name = "textProgress";
			this.textProgress.Size = new System.Drawing.Size(360, 298);
			this.textProgress.TabIndex = 6;
			// 
			// textBooks
			// 
			this.textBooks.Location = new System.Drawing.Point(13, 396);
			this.textBooks.Multiline = true;
			this.textBooks.Name = "textBooks";
			this.textBooks.Size = new System.Drawing.Size(360, 123);
			this.textBooks.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(11, 379);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Books";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(13, 56);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(78, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Game progress";
			// 
			// buttonAsk
			// 
			this.buttonAsk.Enabled = false;
			this.buttonAsk.Location = new System.Drawing.Point(379, 492);
			this.buttonAsk.Name = "buttonAsk";
			this.buttonAsk.Size = new System.Drawing.Size(166, 23);
			this.buttonAsk.TabIndex = 10;
			this.buttonAsk.Text = "Ask for a card";
			this.buttonAsk.UseVisualStyleBackColor = true;
			this.buttonAsk.Click += new System.EventHandler(this.buttonAsk_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(559, 531);
			this.Controls.Add(this.buttonAsk);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBooks);
			this.Controls.Add(this.textProgress);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.buttonStart);
			this.Controls.Add(this.textName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listHand);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listHand;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textName;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textProgress;
		private System.Windows.Forms.TextBox textBooks;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button buttonAsk;
	}
}

