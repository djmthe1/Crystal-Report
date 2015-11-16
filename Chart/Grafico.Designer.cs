namespace Chart
{
    partial class Grafico
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ejemploDeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.agendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chartDbDataSet = new Chart.ChartDbDataSet();
            this.agendaTableAdapter = new Chart.ChartDbDataSetTableAdapters.AgendaTableAdapter();
            this.chartDbDataSet1 = new Chart.ChartDbDataSet1();
            this.agendaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.agendaTableAdapter1 = new Chart.ChartDbDataSet1TableAdapters.AgendaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ejemploDeChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ejemploDeChart
            // 
            chartArea1.Name = "ChartArea1";
            this.ejemploDeChart.ChartAreas.Add(chartArea1);
            this.ejemploDeChart.DataSource = this.agendaBindingSource;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            legend1.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            legend1.Name = "Nombres";
            legend2.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            legend2.Name = "Id";
            this.ejemploDeChart.Legends.Add(legend1);
            this.ejemploDeChart.Legends.Add(legend2);
            this.ejemploDeChart.Location = new System.Drawing.Point(13, 13);
            this.ejemploDeChart.Name = "ejemploDeChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Nombres";
            series1.Name = "Nombres";
            series1.XValueMember = "nombre";
            series1.YValueMembers = "Id";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Id";
            series2.Name = "Id";
            series2.XValueMember = "Id";
            series2.YValueMembers = "Id";
            this.ejemploDeChart.Series.Add(series1);
            this.ejemploDeChart.Series.Add(series2);
            this.ejemploDeChart.Size = new System.Drawing.Size(537, 364);
            this.ejemploDeChart.TabIndex = 0;
            this.ejemploDeChart.Text = "chart";
            // 
            // agendaBindingSource
            // 
            this.agendaBindingSource.DataMember = "Agenda";
            this.agendaBindingSource.DataSource = this.chartDbDataSet;
            // 
            // chartDbDataSet
            // 
            this.chartDbDataSet.DataSetName = "ChartDbDataSet";
            this.chartDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agendaTableAdapter
            // 
            this.agendaTableAdapter.ClearBeforeFill = true;
            // 
            // chartDbDataSet1
            // 
            this.chartDbDataSet1.DataSetName = "ChartDbDataSet1";
            this.chartDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agendaBindingSource1
            // 
            this.agendaBindingSource1.DataMember = "Agenda";
            this.agendaBindingSource1.DataSource = this.chartDbDataSet1;
            // 
            // agendaTableAdapter1
            // 
            this.agendaTableAdapter1.ClearBeforeFill = true;
            // 
            // Grafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 399);
            this.Controls.Add(this.ejemploDeChart);
            this.Name = "Grafico";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Grafico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ejemploDeChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ejemploDeChart;
        private ChartDbDataSet chartDbDataSet;
        private System.Windows.Forms.BindingSource agendaBindingSource;
        private ChartDbDataSetTableAdapters.AgendaTableAdapter agendaTableAdapter;
        private ChartDbDataSet1 chartDbDataSet1;
        private System.Windows.Forms.BindingSource agendaBindingSource1;
        private ChartDbDataSet1TableAdapters.AgendaTableAdapter agendaTableAdapter1;
    }
}

