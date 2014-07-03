using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace Bll
{
    public class BLLindex
    {
        DAL.DALindex index = new DAL.DALindex();
        public DataTable gettableclass()
        {
            return index.gettableclass();
        }
        public DataTable gettabletypename(string str)
        {
            return index.gettabletypename(str);
        }
        public DataTable gettableLetter()
        {
            return index.gettableLetter();
        }
        public DataTable gettableTitle(string str)
        {
            return index.gettableTitle(str );
        }
        public DataTable gettalbearticle(string str)
        {
            return index.gettalbearticle(str);
        }
        public DataTable gettablelink(string str) //返回友情链接
        {
            return index.gettablelink(str );
        }
        public DataTable letterarticle(string str)//返回热点文章
        {
            return index.letterarticle(str );
        }
        public DataTable gettableclassid(string str)//子查询返回classid
        {
            return index.gettableclassid (str );
        }
        public DataTable gettablearticle1(string str)//返回排行榜
        {
            return index.gettablearticle1(str );
        }
        public  DataTable gettabletypename1(string str)// type页面返回小类名
        {
            return index.gettabletypename1(str );
        }
        public DataTable gettalbearticle2(string str)//绑定Type文章题目
        {
            return index.gettalbearticle2(str );
        }
        public DataTable getclassname(string strclasssname)//绑定当前位置的链接1classname
        {
            return index.getclassname (strclasssname );
        }
        public DataTable gettypename(string strtypename)//绑定当前位置的链接2typename
        {
            return index.gettypename(strtypename );
        }
        public DataTable getlastestnews(string str)//绑定最新新闻列表
        {
            return index.getlastestnews(str );
        }
        public DataTable dtLetterArticle(string str)//绑定许平新闻文章
        {
            return index.dtLetterArticle(str );
        }
        public DataTable dtLettername(string str)//绑定所在专题
        {
            return index.dtLettername(str );
        }
        public DataTable dtLetterTitle(string str)//绑定该专题所有文章
        {
            return index.dtLetterTitle(str );
        }
        public DataTable dtimagenews(string str)//图片新闻
        {
            return index.dtimagenews(str );
        }
        public DataTable dtFirst(string str)//第一张图片
        {
            return index.dtFirst(str);
        }
        public DataTable dtothers(string str)//其它图片
        {
            return index.dtothers(str);
        }
        public DataTable dtindexclassname(string str)//首页classname
        {
            return index.dtindexclassname(str);
        }
        public DataTable dtclssarticle(string str)//首页切换文章标题
        {
            return index.dtclssarticle(str);
        }
        public DataTable dtfocusnews(string str)//焦点新闻
        {
            return index.dtfocusnews(str);
        }
        public int hitsarticle(string str)//文章阅读点击率
        {
            return index.hitsarticle(str);
        }
        public DataTable dtupload(string str)//下载
        {
            return index.dtupload(str);
        }
        public void updowncount(string str)//更新点击率
        {
            index.updowncount(str);
        }
      
    }
}
