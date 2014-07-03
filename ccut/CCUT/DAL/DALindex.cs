using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DALindex
    {
        DataAccess ac = new DataAccess();
        public DataTable gettableclass()
        {
            string str = "select  * from class";
            DataTable table = ac.gettable(str);
            return table;
        }
        public DataTable gettabletypename(string str)
        {
            
              return ac.gettable(str );
            
        }
        public DataTable gettableLetter()
        {
            string str = "select * from LetterLink";
            return ac.gettable(str );
        }
        public DataTable gettableTitle(string str)//返回文章标题
        {
            return ac.gettable(str );
        }
        public DataTable gettalbearticle(string str)//返回文章
        {
            return ac.gettable(str);
        }
        public DataTable gettablelink(string str) //返回友情链接
        {
            return ac.gettable(str );
        }
        public DataTable letterarticle(string str)//返回热点文章
        {
            return ac.gettable(str );
        }
        public DataTable gettableclassid(string str)//子查询返回classid
        {
            return ac.gettable(str );
        }
        public DataTable gettablearticle1(string str)//返回排行榜
        {
            return ac.gettable(str );
        }
       public  DataTable gettabletypename1(string str)// type页面返回小类名
        {
            return ac.gettable(str );
        }
       public DataTable gettalbearticle2(string str)//绑定Type文章题目
       {
           return ac.gettable(str);
       }
       public DataTable getclassname(string strclasssname)//绑定当前位置的链接1classname
       {
           return ac.gettable( strclasssname  );
       }
       public DataTable gettypename(string strtypename)//绑定当前位置的链接2typename
       {
           return ac.gettable(strtypename );
       }
       public DataTable getlastestnews(string str)//绑定最新新闻列表
       {
           return ac.gettable(str );
       }
       public DataTable dtLetterArticle(string str)//绑定许平新闻文章
       {
           return ac.gettable(str);
       }
       public DataTable dtLettername(string str)//绑定所在专题
       {
           return ac.gettable(str );
       }
       public DataTable dtLetterTitle(string str)//绑定该专题所有文章
       {
           return ac.gettable(str );
       }
       public DataTable dtimagenews(string str)//图片新闻
       {
           return ac.gettable(str );
       }
       public DataTable dtFirst(string str)//第一张图片
       {
           return ac.gettable(str);
       }
       public DataTable dtothers(string str)//其它图片
       {
           return ac.gettable(str);
       }
       public DataTable dtindexclassname(string str)//首页classname
       {
           return ac.gettable(str);
       }
       public DataTable dtclssarticle(string  str)//首页切换文章标题
       {
           return ac.gettable(str);
       }
       public DataTable dtfocusnews(string str)//焦点新闻
       {
           return ac.gettable(str);
       }
       public int hitsarticle(string str)//文章阅读点击率
       {
           return ac.ExecuteSQL(str );
       }
       public DataTable dtupload(string str)//下载
       {
           return ac.gettable(str);
       }
       public void updowncount(string str)//更新点击率
       {
           ac.ExecuteSQL(str);
       }
      
    }
}
