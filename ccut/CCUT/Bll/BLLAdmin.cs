using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace Bll
{ 
    public  class BLLAdmin
    {
        DAL.DALAdmin admin = new DAL.DALAdmin();
        public SqlDataReader dtLogin(string str)//后台登录
        {
            return admin.dtLogin(str );
        }
        public DataTable dtclassname(string str)//大类名
        {
            return admin.dtclassname(str );
        }
        public DataTable dttypename(string str)//小类名
        {
            return admin.dttypename(str );
        }
         public DataTable dtarticle(string str)//文章标题
        {  
             return admin.dtarticle (str);
         }
         public int deletearticle(string str)//删除文章
         {
             return admin.deletearticle (str);
         }
         public int deleteimagesnews(string str)//删除图片新闻
         {
             return admin.deleteimagesnews(str );
         }
         public DataTable dtimagesnews(string str)//图片新闻
         {
             return admin.dtimagesnews(str );
         }
         public DataTable DTimagesnews(string str,SqlParameter [] para)//图片新闻
        {
            return admin.DTimagesnews(str,para);
         }
      
         public DataTable dtmanaarticle(string str, SqlParameter[] para)//管理文章
         {
             return admin.dtmanaarticle(str,para);
         }
         public DataTable dtmanaarticlecount(string str)//文章总数
         {
             return admin.dtmanaarticlecount(str);
         }
         public DataTable dtmanaLetter(string str)//专题管理
         {
             return admin.dtmanaLetter(str);
         }
         public DataTable DTmanaLetter(string str, SqlParameter[] para)//专题管理
         {
             return admin.DTmanaLetter(str,para);
         }
        
         public DataTable dtmanaupload(string str)//上传下载管理
         {
             return admin.dtmanaupload(str );
         }
         public DataTable DTmanaupload(string str, SqlParameter[] para)//上传下载管理
         {
             return admin.DTmanaupload(str,para);
         }
         public int deleteupload(string str)//删除下载文件链接
         {
             return admin.deleteupload(str);
         }
        public int addnews(string str,SqlParameter [] para)//添加新闻
        {
             return admin.addnews(str,para);
         }
        public DataTable dtLetter(string str)//专题
        {
            return admin.dtLetter(str);
        }
        public DataTable DTLetter(string str, SqlParameter[] para)//专题
        {
            return admin.DTLetter(str,para);
        }
        public int deLetter(string str)//删除专题
        {
            return admin.deLetter(str);
        }
        public int deleteLetter(string str)//删除专题文章
        {
            return admin.deleteLetter(str);
        }
        public int addLetterArticle(string str, SqlParameter[] para)//添加专题文章
        {
            return admin.addLetterArticle(str,para);
        }
        public int addLetter(string str, SqlParameter[] para)//添加专题
        {
            return admin.addLetter(str,para);
        }
        public int addUpload(string str, SqlParameter[] para)//添加附件
        {
            return admin.addUpload(str,para);
        }
        public int addimagesnews(string str, SqlParameter[] para)//添加图片新闻
        {
            return admin.addimagesnews(str,para);
        }
        public int addclass(string str)//添加大类菜单
        {
            return admin.addclass(str);
        }
        public int addtype(string str)//添加小类菜单
        {
            return admin.addtype(str);
        }
        public DataTable dtclass(string str)//绑定大类
        {
            return admin.dtclass(str);
        }
        public DataTable dttype(string str)//绑定小类
        {
            return admin.dttype(str);
        }
        public int deleteclass(string str)//删除大类
        {
            return admin.deleteclass(str);
        }
        public int deletetype(string str)//删除小类
        {
            return admin.deletetype(str);
        }
        public int addlink(string str, SqlParameter[] para)//添加友情链接
        {
            return admin.addlink(str,para);
        }
        public DataTable dtlink(string str)//绑定友情链接
        {
            return admin.dtlink(str);
        }
        public int deletelink(string str)//删除友情链接
        {
            return admin.deletelink(str);
        }
    }
}
