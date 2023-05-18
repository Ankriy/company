
namespace company
{
    partial class graphSalesMonths
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
            this.gpbx_гистограмма = new System.Windows.Forms.GroupBox();
            this.cbBx_graph = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // gpbx_гистограмма
            // 
            this.gpbx_гистограмма.Location = new System.Drawing.Point(12, 3);
            this.gpbx_гистограмма.Name = "gpbx_гистограмма";
            this.gpbx_гистограмма.Size = new System.Drawing.Size(599, 435);
            this.gpbx_гистограмма.TabIndex = 0;
            this.gpbx_гистограмма.TabStop = false;
            this.gpbx_гистограмма.Text = "groupBox1";
            // 
            // cbBx_graph
            // 
            this.cbBx_graph.FormattingEnabled = true;
            this.cbBx_graph.Location = new System.Drawing.Point(617, 12);
            this.cbBx_graph.Name = "cbBx_graph";
            this.cbBx_graph.Size = new System.Drawing.Size(186, 24);
            this.cbBx_graph.TabIndex = 2;
            this.cbBx_graph.SelectedIndexChanged += new System.EventHandler(this.cbBx_graph_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(617, 42);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(213, 284);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // graphSalesMonths
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 467);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cbBx_graph);
            this.Controls.Add(this.gpbx_гистограмма);
            this.Name = "graphSalesMonths";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbx_гистограмма;
        private System.Windows.Forms.ComboBox cbBx_graph;
        private System.Windows.Forms.ListView listView1;
    }
}