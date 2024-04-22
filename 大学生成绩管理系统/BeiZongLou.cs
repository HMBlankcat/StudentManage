using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    public partial class BeiZongLou : Form
    {
        string Filename = ""; //存储文件路径
        public BeiZongLou()
        {
            InitializeComponent();
        }

        private void BeiZongLou_Load(object sender, EventArgs e)
        {




        }
        

        private void axMapControl1_OnMouseDown(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMouseDownEvent e)
        {
            // 地图控件鼠标按下事件
            if (e.button == 4)//鼠标中键
            {
                axMapControl1.Pan();//鼠标中键平移地图
            }

            try
            {
                IMap map = axMapControl1.Map; // 获取地图对象
                IEnvelope pEeo = axMapControl1.TrackRectangle(); // 获取鼠标所绘制的矩形范围
                axMapControl1.Map.SelectByShape(pEeo, null, false);  // 通过矩形范围选择要素
                axMapControl1.ActiveView.Refresh();
                // 获取选择集
                //　ArcGIS中FeatureSelection默认的时候只存入Feature 的Shape，
                //　而不是整个Feature的字段数据。如果要查看完整的属性信息，必须要进行以下转换才可以。
                ISelection selection = map.FeatureSelection;
                IEnumFeatureSetup iEnumFeatureSetup = (IEnumFeatureSetup)selection;
                iEnumFeatureSetup.AllFields = true;
                IEnumFeature enumFeature = (IEnumFeature)iEnumFeatureSetup;//选中要素属性信息
                enumFeature.Reset();
                IFeature feature = enumFeature.Next();
                //IEnumFeature 接口代表一个要素的枚举器，可以用来遍历要素选择集或要素层中的所有要素。
                //Next() 方法用于获取枚举器中的下一个要素，如果存在下一个要素，则返回该要素；如果没有下一个要素，则返回 null。

                // 根据文件路径判断处理
                if (Filename == "F:/COLLEGE2/数据库课设/徐梓茗-大学生成绩管理系统/大学生课程学习管理与成绩评价系统/BZ11.mxd")
                {
                    // 遍历选择的要素
                    while (feature != null)
                    {
                        // 获取第一个字段的值
                        string xuanze = feature.get_Value(0).ToString();//这边get_Value(0)里面的数字代表你shapefile文件里面dbf表中字段的位置，0代表第一个
                        // 根据字段值设置标签文本
                        if (xuanze == "0")
                        {
                            label7.Text = "北综楼101";
                        }
                        else if(xuanze == "1")
                        {
                            label7.Text = "北综楼102";
                        }
                        else if (xuanze == "2")
                        {
                            label7.Text = "北综楼103";
                        }
                        else if (xuanze == "3")
                        {
                            label7.Text = "北综楼104";
                        }
                        else if (xuanze == "4")
                        {
                            label7.Text = "北综楼105";
                        }
                        else if (xuanze == "5")
                        {
                            label7.Text = "北综楼106";
                        }
                        else if (xuanze == "6")
                        {
                            label7.Text = "北综楼107";
                        }
                        else if (xuanze == "7")
                        {
                            label7.Text = "北综楼108";
                        }
                        else if (xuanze == "8")
                        {
                            label7.Text = "北综楼109";
                        }
                        else
                        {

                        }

                        feature = enumFeature.Next();// 获取下一个要素
                    }
                }
                else if(Filename == "F:/COLLEGE2/数据库课设/徐梓茗-大学生成绩管理系统/大学生课程学习管理与成绩评价系统/BZ22.mxd")
                {
                    while (feature != null)
                    {
                        string xuanze = feature.get_Value(0).ToString();//这边get_Value(0)里面的数字代表你shapefile文件里面dbf表中字段的位置，0代表第一个
                        if (xuanze == "0")
                        {
                            label7.Text = "北综楼201";
                        }
                        else if (xuanze == "1")
                        {
                            label7.Text = "北综楼202";
                        }
                        else if (xuanze == "2")
                        {
                            label7.Text = "北综楼203";
                        }
                        else if (xuanze == "3")
                        {
                            label7.Text = "北综楼204";
                        }
                        else if (xuanze == "4")
                        {
                            label7.Text = "北综楼205";
                        }
                        else if (xuanze == "5")
                        {
                            label7.Text = "北综楼206";
                        }
                        else if (xuanze == "6")
                        {
                            label7.Text = "北综楼207";
                        }
                        else if (xuanze == "7")
                        {
                            label7.Text = "北综楼208";
                        }
                        else if (xuanze == "8")
                        {
                            label7.Text = "北综楼209";
                        }
                        else
                        {
                            MessageBox.Show("请正确选择教室！");
                        }
                        feature = enumFeature.Next();
                    }
                }
                else
                {
                    MessageBox.Show("请先点击左侧按钮选择楼层！");
                }

            }
            catch (Exception )
            {
            }
            //while (true)
            //{
            //    IEnvelope pEeo = axMapControl1.TrackRectangle();
            //    axMapControl1.Map.SelectByShape(pEeo, null, false);
            //    axMapControl1.ActiveView.Refresh();
                
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Filename = "F:/COLLEGE2/数据库课设/徐梓茗-大学生成绩管理系统/大学生课程学习管理与成绩评价系统/BZ11.mxd";
            axMapControl1.ClearLayers();// 清除图层
            axMapControl1.LoadMxFile(Filename);// 加载地图文档
            //if (pOpenFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //   string pFileName = pOpenFileDialog.FileName;
            //   if (pFileName == "")
            //    {
            //       return;
            //    }
            //   if (axMapControl1.CheckMxFile(pFileName))//检查地图文档是否有效
            //    {
            // ClearAllData();
            //       axMapControl1.LoadMxFile(pFileName);
            //   }
            //   else
            //   {
            //       MessageBox.Show(pFileName + "是无效的地图文档！", "信息提示");
            //       return;
            // }
        //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Filename = "F:/COLLEGE2/数据库课设/徐梓茗-大学生成绩管理系统/大学生课程学习管理与成绩评价系统/BZ22.mxd";
            axMapControl1.ClearLayers();
            axMapControl1.LoadMxFile(Filename);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Data.Classroom = label7.Text;// 将标签文本保存至Data类中的Classroom属性
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
