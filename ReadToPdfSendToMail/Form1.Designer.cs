namespace ReadToPdfSendToMail
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dizinIcerigiListView = new System.Windows.Forms.ListView();
            this.File = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewEmail = new System.Windows.Forms.ListView();
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listIsSended = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // dizinIcerigiListView
            // 
            this.dizinIcerigiListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.File});
            this.dizinIcerigiListView.Location = new System.Drawing.Point(12, 51);
            this.dizinIcerigiListView.Name = "dizinIcerigiListView";
            this.dizinIcerigiListView.Size = new System.Drawing.Size(107, 345);
            this.dizinIcerigiListView.TabIndex = 2;
            this.dizinIcerigiListView.UseCompatibleStateImageBehavior = false;
            this.dizinIcerigiListView.View = System.Windows.Forms.View.List;
            // 
            // listViewEmail
            // 
            this.listViewEmail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Email});
            this.listViewEmail.Location = new System.Drawing.Point(144, 51);
            this.listViewEmail.Name = "listViewEmail";
            this.listViewEmail.Size = new System.Drawing.Size(255, 345);
            this.listViewEmail.TabIndex = 3;
            this.listViewEmail.UseCompatibleStateImageBehavior = false;
            this.listViewEmail.View = System.Windows.Forms.View.List;
            // 
            // Email
            // 
            this.Email.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "PDF İsimleri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(204, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email Adresleri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(418, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email Durumu";
            // 
            // listIsSended
            // 
            this.listIsSended.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listIsSended.Location = new System.Drawing.Point(422, 51);
            this.listIsSended.Name = "listIsSended";
            this.listIsSended.Size = new System.Drawing.Size(132, 345);
            this.listIsSended.TabIndex = 6;
            this.listIsSended.UseCompatibleStateImageBehavior = false;
            this.listIsSended.View = System.Windows.Forms.View.List;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 419);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listIsSended);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewEmail);
            this.Controls.Add(this.dizinIcerigiListView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Otomatik Mail Gönderim Scripti";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView dizinIcerigiListView;
        private System.Windows.Forms.ColumnHeader File;
        private System.Windows.Forms.ListView listViewEmail;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listIsSended;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

