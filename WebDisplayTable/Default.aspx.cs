using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public class Car
{
    public string Brand { get; set; }
    public string Merk { get; set; }
    public string Transmisi { get; set; }
    public string Price { get; set; }
}
public partial class _Default : Page
{
    //void ShowingGroupingDataInGridView(GridViewRowCollection gridViewRows, int startIndex, int totalColumns)
    //{
    //    if (totalColumns == 0) return;
    //    int i, count = 1;
    //    ArrayList lst = new ArrayList();
    //    lst.Add(gridViewRows[0]);
    //    var ctrl = gridViewRows[0].Cells[startIndex];
    //    for (i = 1; i < gridViewRows.Count; i++)
    //    {
    //        TableCell nextTbCell = gridViewRows[i].Cells[startIndex];
    //        if (ctrl.Text == nextTbCell.Text)
    //        {
    //            count++;
    //            nextTbCell.Visible = false;
    //            lst.Add(gridViewRows[i]);
    //        }
    //        else
    //        {
    //            if (count > 1)
    //            {
    //                ctrl.RowSpan = count;
    //                ShowingGroupingDataInGridView(new GridViewRowCollection(lst), startIndex + 1, totalColumns - 1);
    //            }
    //            count = 1;
    //            lst.Clear();
    //            ctrl = gridViewRows[i].Cells[startIndex];
    //            lst.Add(gridViewRows[i]);
    //        }
    //    }
    //    if (count > 1)
    //    {
    //        ctrl.RowSpan = count;
    //        ShowingGroupingDataInGridView(new GridViewRowCollection(lst), startIndex + 1, totalColumns - 1);
    //    }
    //    count = 1;
    //    lst.Clear();
    //}
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //   string[,] mobil = new string[,]
            //{
            //        { "Ford", "Fiesta", "Manual", "Rp 120.000.000"},
            //        { "", "", "", "Rp 134.000.000"},
            //        { "", "", "Automatic", "Rp 140.000.000"},
            //        { "", "", "", "Rp 150.000.000"},
            //        { "", "Focus", "Manual", "Rp 330.000.000"},
            //        { "", "", "", "Rp 335.000.000"},
            //        { "", "", "", "Rp 350.000.000"},
            //        { "", "", "Automatic", "Rp 360.000.000"},
            //        { "VW", "Golf", "Manual", "Rp 350.000.000"},
            //        { "", "", "Automatic", "Rp 370.000.000"},

            //};
            string[,] mobil = new string[,]
               {
                 { "Ford", "Fiesta", "Manual", "Rp 120.000.000"},
                 { "Ford", "Fiesta", "Manual", "Rp 134.000.000"},
                 { "Ford", "Fiesta", "Automatic", "Rp 140.000.000"},
                 { "Ford", "Fiesta", "Automatic", "Rp 150.000.000"},
                 { "Ford", "Focus", "Manual", "Rp 330.000.000"},
                 { "Ford", "Focus", "Manual", "Rp 335.000.000"},
                 { "Ford", "Focus", "Manual", "Rp 350.000.000"},
                 { "Ford", "Focus", "Automatic", "Rp 360.000.000"},
                 { "VW", "Golf", "Manual", "Rp 350.000.000"},
                 { "VW", "Golf", "Automatic", "Rp 370.000.000"},

               };
            List<Car> lsMobil = new List<Car>();
          

            int rows = mobil.GetLength(0);
            int cols = mobil.GetLength(1);

            for(int i=0; i < rows; i++)
            {
                lsMobil.Add(new Car
                {
                    Brand=mobil[i,0],
                    Merk=mobil[i,1],
                    Transmisi = mobil[i, 2],
                    Price = mobil[i, 3]
                });
            }
            GridViewHelper helper = new GridViewHelper(this.gv, false);
            helper.RegisterGroup("Brand", true, true);
            helper.ApplyGroupSort();
            gv.DataSource = lsMobil;
            gv.DataBind();
            
           
        }
    }

    protected void gv_Sorting(object sender, GridViewSortEventArgs e)
    {

    }
}