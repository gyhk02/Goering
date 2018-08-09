using Goering.Model.Vo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Goering.Web.Common
{
    public class DirectoryList
    {
        List<LeftDirectoryVo> lstLeftDirectoryVo = new List<LeftDirectoryVo>();
        Dictionary<string, string> ChineseAndEnglishRelations = new Dictionary<string, string>();

        #region 初始化中英文对应关系
        /// <summary>
        /// 初始化中英文对应关系
        /// </summary>
        private void InitRelations()
        {
            ChineseAndEnglishRelations.Clear();

            ChineseAndEnglishRelations.Add("Index", "首页");
            ChineseAndEnglishRelations.Add("DynamicList", "动态列表");
            ChineseAndEnglishRelations.Add("Dynamic", "动态详情");
            ChineseAndEnglishRelations.Add("PublicationList", "月刊列表");
            ChineseAndEnglishRelations.Add("Publication", "月刊详情");

            ChineseAndEnglishRelations.Add("About", "关于荣诚");
            ChineseAndEnglishRelations.Add("Introduction", "集团简介");
            ChineseAndEnglishRelations.Add("EVN", "&ensp;&ensp;&ensp;EVN");
            ChineseAndEnglishRelations.Add("EVH", "&ensp;&ensp;&ensp;EVH");
            ChineseAndEnglishRelations.Add("EVL", "&ensp;&ensp;&ensp;EVL");
            ChineseAndEnglishRelations.Add("EVM", "&ensp;&ensp;&ensp;EVM");
            ChineseAndEnglishRelations.Add("EVC", "&ensp;&ensp;&ensp;EVC");
            ChineseAndEnglishRelations.Add("PRB", "&ensp;&ensp;&ensp;PRB");
            ChineseAndEnglishRelations.Add("Culture", "企业文化");
            ChineseAndEnglishRelations.Add("Winning", "获奖殊荣");

            //ChineseAndEnglishRelations.Add("Technology", "核心技术");
            ChineseAndEnglishRelations.Add("machine", "生产机台");

            ChineseAndEnglishRelations.Add("Responsibility", "企业社会责任");
            ChineseAndEnglishRelations.Add("LabourUnion", "工会互动");
            ChineseAndEnglishRelations.Add("Activity", "公益活动");
            ChineseAndEnglishRelations.Add("LaborSafety", "职业安全");
            ChineseAndEnglishRelations.Add("EnvironmentalSafety", "绿色生产");
            ChineseAndEnglishRelations.Add("Capital", "劳资关系");
            ChineseAndEnglishRelations.Add("Train", "员工培育");

            ChineseAndEnglishRelations.Add("Job", "人才招聘");
            ChineseAndEnglishRelations.Add("JobOpenings", "招聘职位");
            ChineseAndEnglishRelations.Add("JobTitle", "应聘职位");
            //ChineseAndEnglishRelations.Add("SalaryWelfare", "薪资福利");
            ChineseAndEnglishRelations.Add("TalentIdea", "人才理念");
            ChineseAndEnglishRelations.Add("BigFamily", "荣诚大家庭");

            ChineseAndEnglishRelations.Add("Contact", "联系我们");
        }
        #endregion

        #region 初始化VO
        /// <summary>
        /// 初始化VO
        /// </summary>
        private void InitVo()
        {
            lstLeftDirectoryVo.Clear();

            LeftDirectoryVo model = new LeftDirectoryVo();

            #region Index

            model = new LeftDirectoryVo();
            model.BigClass = "Index";
            model.SmallClass = "DynamicList";
            lstLeftDirectoryVo.Add(model);

            model = new LeftDirectoryVo();
            model.BigClass = "Index";
            model.SmallClass = "PublicationList";
            lstLeftDirectoryVo.Add(model);

            #endregion

            #region About

            model = new LeftDirectoryVo();
            model.BigClass = "About";
            model.SmallClass = "Introduction";
            lstLeftDirectoryVo.Add(model);

            model = new LeftDirectoryVo();
            model.BigClass = "About";
            model.SmallClass = "EVN";
            lstLeftDirectoryVo.Add(model);

            model = new LeftDirectoryVo();
            model.BigClass = "About";
            model.SmallClass = "EVH";
            lstLeftDirectoryVo.Add(model);

            model = new LeftDirectoryVo();
            model.BigClass = "About";
            model.SmallClass = "EVL";
            lstLeftDirectoryVo.Add(model);

            model = new LeftDirectoryVo();
            model.BigClass = "About";
            model.SmallClass = "EVM";
            lstLeftDirectoryVo.Add(model);

            model = new LeftDirectoryVo();
            model.BigClass = "About";
            model.SmallClass = "EVC";
            lstLeftDirectoryVo.Add(model);

            model = new LeftDirectoryVo();
            model.BigClass = "About";
            model.SmallClass = "PRB";
            lstLeftDirectoryVo.Add(model);

            model = new LeftDirectoryVo();
            model.BigClass = "About";
            model.SmallClass = "Culture";
            lstLeftDirectoryVo.Add(model);

            model = new LeftDirectoryVo();
            model.BigClass = "About";
            model.SmallClass = "Winning";
            lstLeftDirectoryVo.Add(model);

            #endregion

            #region Technology



            //model = new LeftDirectoryVo();
            //model.BigClass = "Technology";
            ////model.SmallClass = "TPUPowder";
            ////lstLeftDirectoryVo.Add(model);

            //model = new LeftDirectoryVo();
            //model.BigClass = "Technology";
            //model.SmallClass = "Process";
            //lstLeftDirectoryVo.Add(model);


            //model = new LeftDirectoryVo();
            //model.BigClass = "Technology";
            //model.SmallClass = "2DPUR";
            //lstLeftDirectoryVo.Add(model);

            //model = new LeftDirectoryVo();
            //model.BigClass = "Technology";
            //model.SmallClass = "3DPUR";
            //lstLeftDirectoryVo.Add(model);


            //model = new LeftDirectoryVo();
            //model.BigClass = "Technology";
            //model.SmallClass = "CS";
            //lstLeftDirectoryVo.Add(model);

            //model = new LeftDirectoryVo();
            //model.BigClass = "Technology";
            //model.SmallClass = "IR";
            //lstLeftDirectoryVo.Add(model);

            //model = new LeftDirectoryVo();
            //model.BigClass = "Technology";
            //model.SmallClass = "machine";
            //lstLeftDirectoryVo.Add(model);

            #endregion

            #region Responsibility

            model = new LeftDirectoryVo();
            model.BigClass = "Responsibility";
            model.SmallClass = "LabourUnion";
            lstLeftDirectoryVo.Add(model);
            
            model = new LeftDirectoryVo();
            model.BigClass = "Responsibility";
            model.SmallClass = "Activity";
            lstLeftDirectoryVo.Add(model);

            model = new LeftDirectoryVo();
            model.BigClass = "Responsibility";
            model.SmallClass = "LaborSafety";
            lstLeftDirectoryVo.Add(model);


            model = new LeftDirectoryVo();
            model.BigClass = "Responsibility";
            model.SmallClass = "EnvironmentalSafety";

            model = new LeftDirectoryVo();
            model.BigClass = "Responsibility";
            model.SmallClass = "Capital";
            lstLeftDirectoryVo.Add(model);

            model = new LeftDirectoryVo();
            model.BigClass = "Responsibility";
            model.SmallClass = "Train";
            lstLeftDirectoryVo.Add(model);

            

            #endregion

            #region Job

            model = new LeftDirectoryVo();
            model.BigClass = "Job";
            model.SmallClass = "JobOpenings";
            lstLeftDirectoryVo.Add(model);

            //model = new LeftDirectoryVo();
            //model.BigClass = "Job";
            //model.SmallClass = "JobTitle";
            //lstLeftDirectoryVo.Add(model);

            //model = new LeftDirectoryVo();
            //model.BigClass = "Job";
            //model.SmallClass = "SalaryWelfare";
            //lstLeftDirectoryVo.Add(model);


            model = new LeftDirectoryVo();
            model.BigClass = "Job";
            model.SmallClass = "TalentIdea";
            lstLeftDirectoryVo.Add(model);

            model = new LeftDirectoryVo();
            model.BigClass = "Job";
            model.SmallClass = "BigFamily";
            lstLeftDirectoryVo.Add(model);

            #endregion

        }
        #endregion

        #region 根据大类获取全部小类
        /// <summary>
        /// 根据大类获取全部小类
        /// </summary>
        /// <param name="pBigClass"></param>
        /// <returns></returns>
        public List<LeftDirectoryVo> GetList(string pBigClass)
        {
            InitVo();

            List<LeftDirectoryVo> lst = new List<LeftDirectoryVo>();

            foreach (LeftDirectoryVo vo in lstLeftDirectoryVo)
            {
                if (vo.BigClass == pBigClass)
                {
                    lst.Add(vo);
                }
            }

            return lst;
        }
        #endregion

        #region 获取中文
        /// <summary>
        /// 获取中文
        /// </summary>
        /// <param name="pValue"></param>
        /// <returns></returns>
        public string GetChinese(string pKey)
        {
            InitRelations();

            string result = "";
            result = ChineseAndEnglishRelations[pKey];
            return result;
        }
        #endregion

    }

    //首页			Index
    //    动态列表	DynamicList
    //    动态详情	Dynamic
    //    月刊列表	PublicationList
    //    月刊详情	Publication
    //走进荣诚		About
    //    集团简介	Introduction
    //    企业文化	Culture
    //    获奖殊荣	Winning
    //核心技术		Technology
    //    制鞋流程	Process
    //    TPU Powder	TPUPowder
    //    2D PUR		2DPUR
    //    3D PUR		3DPUR
    //    CS		CS
    //    IR		IR
    //社会责任		Responsibility
    //    公益活动	Activity
    //    职业安全	LaborSafety
    //    绿色生产	EnvironmentalSafety
    //人才招聘		Job
    //    招聘岗位	JobOpenings
    //    应聘职位	JobTitle
    //    薪资福利	SalaryWelfare
    //    人才理念	TalentIdea
    //    荣诚大家庭	BigFamily
    //联系我们		Contact
}