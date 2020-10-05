namespace FormMain
{
    partial class FormPersonajes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonajes));
            this.lsvPersonajes = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsvPersonajes
            // 
            this.lsvPersonajes.HideSelection = false;
            this.lsvPersonajes.LargeImageList = this.imageList1;
            this.lsvPersonajes.Location = new System.Drawing.Point(103, 56);
            this.lsvPersonajes.Name = "lsvPersonajes";
            this.lsvPersonajes.Size = new System.Drawing.Size(556, 300);
            this.lsvPersonajes.SmallImageList = this.imageList1;
            this.lsvPersonajes.TabIndex = 0;
            this.lsvPersonajes.UseCompatibleStateImageBehavior = false;
            this.lsvPersonajes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lsvPersonajes_MouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "pngegg (1).png");
            this.imageList1.Images.SetKeyName(1, "pngegg (2).png");
            this.imageList1.Images.SetKeyName(2, "pngegg (3).png");
            this.imageList1.Images.SetKeyName(3, "pngegg (4).png");
            this.imageList1.Images.SetKeyName(4, "pngegg (5).png");
            this.imageList1.Images.SetKeyName(5, "pngegg (6).png");
            this.imageList1.Images.SetKeyName(6, "pngegg (7).png");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Personajes";
            // 
            // FormPersonajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lsvPersonajes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormPersonajes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kwik E Mart -> Personajes";
            this.Load += new System.EventHandler(this.FormPersonajes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvPersonajes;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label2;
    }
}