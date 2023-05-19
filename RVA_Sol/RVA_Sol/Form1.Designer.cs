
namespace RVA_Sol
{
  partial class Form1
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.lblEncryptedData = new System.Windows.Forms.Label();
      this.lblDecryptedData = new System.Windows.Forms.Label();
      this.btnCheckIntegrity = new System.Windows.Forms.Button();
      this.txtInputData = new System.Windows.Forms.TextBox();
      this.lblIntegrity = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lblEncryptedData
      // 
      this.lblEncryptedData.AutoSize = true;
      this.lblEncryptedData.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lblEncryptedData.Location = new System.Drawing.Point(551, 50);
      this.lblEncryptedData.Name = "lblEncryptedData";
      this.lblEncryptedData.Size = new System.Drawing.Size(0, 27);
      this.lblEncryptedData.TabIndex = 0;
      // 
      // lblDecryptedData
      // 
      this.lblDecryptedData.AutoSize = true;
      this.lblDecryptedData.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lblDecryptedData.Location = new System.Drawing.Point(551, 157);
      this.lblDecryptedData.Name = "lblDecryptedData";
      this.lblDecryptedData.Size = new System.Drawing.Size(0, 27);
      this.lblDecryptedData.TabIndex = 1;
      // 
      // btnCheckIntegrity
      // 
      this.btnCheckIntegrity.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.btnCheckIntegrity.Location = new System.Drawing.Point(523, 560);
      this.btnCheckIntegrity.Name = "btnCheckIntegrity";
      this.btnCheckIntegrity.Size = new System.Drawing.Size(135, 53);
      this.btnCheckIntegrity.TabIndex = 2;
      this.btnCheckIntegrity.Text = "button1";
      this.btnCheckIntegrity.UseVisualStyleBackColor = true;
      this.btnCheckIntegrity.Click += new System.EventHandler(this.btnCheckIntegrity_Click);
      // 
      // txtInputData
      // 
      this.txtInputData.Location = new System.Drawing.Point(540, 405);
      this.txtInputData.Name = "txtInputData";
      this.txtInputData.Size = new System.Drawing.Size(100, 22);
      this.txtInputData.TabIndex = 3;
      // 
      // lblIntegrity
      // 
      this.lblIntegrity.AutoSize = true;
      this.lblIntegrity.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lblIntegrity.Location = new System.Drawing.Point(551, 252);
      this.lblIntegrity.Name = "lblIntegrity";
      this.lblIntegrity.Size = new System.Drawing.Size(0, 27);
      this.lblIntegrity.TabIndex = 4;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1169, 666);
      this.Controls.Add(this.lblIntegrity);
      this.Controls.Add(this.txtInputData);
      this.Controls.Add(this.btnCheckIntegrity);
      this.Controls.Add(this.lblDecryptedData);
      this.Controls.Add(this.lblEncryptedData);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblEncryptedData;
    private System.Windows.Forms.Label lblDecryptedData;
    private System.Windows.Forms.Button btnCheckIntegrity;
    private System.Windows.Forms.TextBox txtInputData;
    private System.Windows.Forms.Label lblIntegrity;
  }
}

