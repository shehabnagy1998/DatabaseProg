namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.name_search_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.id_search_txt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.insert_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.id_insert_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.name_insert_txt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.update_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.id_update_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.name_update_txt = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.delete_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.id_delete_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.name_delete_txt = new System.Windows.Forms.TextBox();
            this.con_lbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.search_btn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.name_search_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.id_search_txt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(173, 132);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(127, 32);
            this.search_btn.TabIndex = 4;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // name_search_txt
            // 
            this.name_search_txt.Location = new System.Drawing.Point(117, 86);
            this.name_search_txt.Name = "name_search_txt";
            this.name_search_txt.Size = new System.Drawing.Size(333, 29);
            this.name_search_txt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // id_search_txt
            // 
            this.id_search_txt.Location = new System.Drawing.Point(117, 51);
            this.id_search_txt.Name = "id_search_txt";
            this.id_search_txt.Size = new System.Drawing.Size(333, 29);
            this.id_search_txt.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.insert_btn);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.id_insert_txt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.name_insert_txt);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 178);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Insert";
            // 
            // insert_btn
            // 
            this.insert_btn.Location = new System.Drawing.Point(173, 132);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(127, 32);
            this.insert_btn.TabIndex = 4;
            this.insert_btn.Text = "Insert";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // id_insert_txt
            // 
            this.id_insert_txt.Location = new System.Drawing.Point(127, 49);
            this.id_insert_txt.Name = "id_insert_txt";
            this.id_insert_txt.Size = new System.Drawing.Size(333, 29);
            this.id_insert_txt.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "ID";
            // 
            // name_insert_txt
            // 
            this.name_insert_txt.Location = new System.Drawing.Point(127, 86);
            this.name_insert_txt.Name = "name_insert_txt";
            this.name_insert_txt.Size = new System.Drawing.Size(333, 29);
            this.name_insert_txt.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.update_btn);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.id_update_txt);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.name_update_txt);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(541, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(482, 178);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update";
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(173, 132);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(127, 32);
            this.update_btn.TabIndex = 4;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Name";
            // 
            // id_update_txt
            // 
            this.id_update_txt.Location = new System.Drawing.Point(127, 49);
            this.id_update_txt.Name = "id_update_txt";
            this.id_update_txt.Size = new System.Drawing.Size(333, 29);
            this.id_update_txt.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "ID";
            // 
            // name_update_txt
            // 
            this.name_update_txt.Location = new System.Drawing.Point(127, 86);
            this.name_update_txt.Name = "name_update_txt";
            this.name_update_txt.Size = new System.Drawing.Size(333, 29);
            this.name_update_txt.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.delete_btn);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.id_delete_txt);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.name_delete_txt);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(541, 239);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(482, 178);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Delete";
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(173, 132);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(127, 32);
            this.delete_btn.TabIndex = 4;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "Name";
            // 
            // id_delete_txt
            // 
            this.id_delete_txt.Location = new System.Drawing.Point(127, 49);
            this.id_delete_txt.Name = "id_delete_txt";
            this.id_delete_txt.Size = new System.Drawing.Size(333, 29);
            this.id_delete_txt.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "ID";
            // 
            // name_delete_txt
            // 
            this.name_delete_txt.Location = new System.Drawing.Point(127, 86);
            this.name_delete_txt.Name = "name_delete_txt";
            this.name_delete_txt.Size = new System.Drawing.Size(333, 29);
            this.name_delete_txt.TabIndex = 0;
            // 
            // con_lbl
            // 
            this.con_lbl.AutoSize = true;
            this.con_lbl.Location = new System.Drawing.Point(12, 431);
            this.con_lbl.Name = "con_lbl";
            this.con_lbl.Size = new System.Drawing.Size(35, 13);
            this.con_lbl.TabIndex = 4;
            this.con_lbl.Text = "label9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 453);
            this.Controls.Add(this.con_lbl);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_search_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id_search_txt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox id_insert_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name_insert_txt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox id_update_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox name_update_txt;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox id_delete_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox name_delete_txt;
        private System.Windows.Forms.Label con_lbl;
    }
}

