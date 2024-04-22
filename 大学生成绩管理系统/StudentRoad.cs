using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.IO;// 与路径的处理相关(在本程序中), 为了使用其中的Path类(其是静态的)
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Carto;  // 为了使用其中的ILayer类
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Geodatabase;


namespace 大学生课程学习管理与成绩评价系统
{
    public partial class StudentRoad : Form
    {
        public StudentRoad()
        {
            InitializeComponent();
        }

        private void StudentRoad_Load(object sender, EventArgs e)
        {

        }

        private void axMapControl1_OnMouseDown(object sender, IMapControlEvents2_OnMouseDownEvent e)
        {
            //总体与Beizonglou.cs相似，故不再添加注释
            if (e.button == 4)//鼠标中键
            {
                axMapControl1.Pan();//鼠标中键平移地图
            }

            IMap map = axMapControl1.Map;
            IEnvelope pEeo = axMapControl1.TrackRectangle();
            axMapControl1.Map.SelectByShape(pEeo, null, false);
            axMapControl1.ActiveView.Refresh();
            ISelection selection = map.FeatureSelection;
            IEnumFeatureSetup iEnumFeatureSetup = (IEnumFeatureSetup)selection;
            iEnumFeatureSetup.AllFields = true;
            IEnumFeature enumFeature = (IEnumFeature)iEnumFeatureSetup;
            enumFeature.Reset();
            IFeature feature = enumFeature.Next();
            while (feature != null)
            {
                string xuanze = feature.get_Value(0).ToString();//这边get_Value(0)里面的数字代表你shapefile文件里面dbf表中字段的位置，0代表第一个
                label7.Text = xuanze;
                if (xuanze == "5" || xuanze == "6" || xuanze == "7" || xuanze == "8" || xuanze == "9" || xuanze == "10" )
                {
                    label2.Text = "最短路径：MPA中心->致远路->北区综合楼";
                }
                else if (xuanze == "28" || xuanze == "29" || xuanze == "13" || xuanze == "14" || xuanze == "20" || xuanze == "21" || xuanze == "11" || xuanze == "12")
                {
                    label2.Text = "最短路径：致远路->北区综合楼";
                }
                else if (xuanze == "41" || xuanze == "42" || xuanze == "15" || xuanze == "16" || xuanze == "17" || xuanze == "18" || xuanze == "19" 
                    || xuanze == "12" || xuanze == "44" || xuanze == "22" || xuanze == "27")
                {
                    label2.Text = "最短路径：北一路->北二路->致远路->北区综合楼";
                }
                else if (xuanze == "23" || xuanze == "24" || xuanze == "25" || xuanze == "26" || xuanze == "45" || xuanze == "46" || xuanze == "43"
                    || xuanze == "40" || xuanze == "49" || xuanze == "50" || xuanze == "47")
                {
                    label2.Text = "最短路径：北二路->致远路->北区综合楼";
                }
                else if (xuanze == "51" || xuanze == "37" || xuanze == "38" || xuanze == "39" || xuanze == "36" || xuanze == "48" || xuanze == "52")
                {
                    label2.Text = "最短路径：北三路->致远路->北区综合楼";
                }
                else if (xuanze == "34" || xuanze == "35")
                {
                    label2.Text = "最短路径：致远路->北区综合楼";
                    
                }
                else
                {


                }
                feature = enumFeature.Next();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
