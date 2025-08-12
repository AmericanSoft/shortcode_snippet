using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Deawoo
{
    #region Wp_actionscheduler_actions
    public class Wp_actionscheduler_actions
    {
        #region Member Variables
        protected unknown _action_id;
        protected string _hook;
        protected string _status;
        protected DateTime _scheduled_date_gmt;
        protected DateTime _scheduled_date_local;
        protected bool _priority;
        protected string _args;
        protected string _schedule;
        protected unknown _group_id;
        protected int _attempts;
        protected DateTime _last_attempt_gmt;
        protected DateTime _last_attempt_local;
        protected unknown _claim_id;
        protected string _extended_args;
        #endregion
        #region Constructors
        public Wp_actionscheduler_actions() { }
        public Wp_actionscheduler_actions(string hook, string status, DateTime scheduled_date_gmt, DateTime scheduled_date_local, bool priority, string args, string schedule, unknown group_id, int attempts, DateTime last_attempt_gmt, DateTime last_attempt_local, unknown claim_id, string extended_args)
        {
            this._hook=hook;
            this._status=status;
            this._scheduled_date_gmt=scheduled_date_gmt;
            this._scheduled_date_local=scheduled_date_local;
            this._priority=priority;
            this._args=args;
            this._schedule=schedule;
            this._group_id=group_id;
            this._attempts=attempts;
            this._last_attempt_gmt=last_attempt_gmt;
            this._last_attempt_local=last_attempt_local;
            this._claim_id=claim_id;
            this._extended_args=extended_args;
        }
        #endregion
        #region Public Properties
        public virtual unknown Action_id
        {
            get {return _action_id;}
            set {_action_id=value;}
        }
        public virtual string Hook
        {
            get {return _hook;}
            set {_hook=value;}
        }
        public virtual string Status
        {
            get {return _status;}
            set {_status=value;}
        }
        public virtual DateTime Scheduled_date_gmt
        {
            get {return _scheduled_date_gmt;}
            set {_scheduled_date_gmt=value;}
        }
        public virtual DateTime Scheduled_date_local
        {
            get {return _scheduled_date_local;}
            set {_scheduled_date_local=value;}
        }
        public virtual bool Priority
        {
            get {return _priority;}
            set {_priority=value;}
        }
        public virtual string Args
        {
            get {return _args;}
            set {_args=value;}
        }
        public virtual string Schedule
        {
            get {return _schedule;}
            set {_schedule=value;}
        }
        public virtual unknown Group_id
        {
            get {return _group_id;}
            set {_group_id=value;}
        }
        public virtual int Attempts
        {
            get {return _attempts;}
            set {_attempts=value;}
        }
        public virtual DateTime Last_attempt_gmt
        {
            get {return _last_attempt_gmt;}
            set {_last_attempt_gmt=value;}
        }
        public virtual DateTime Last_attempt_local
        {
            get {return _last_attempt_local;}
            set {_last_attempt_local=value;}
        }
        public virtual unknown Claim_id
        {
            get {return _claim_id;}
            set {_claim_id=value;}
        }
        public virtual string Extended_args
        {
            get {return _extended_args;}
            set {_extended_args=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Deawoo
{
    #region Wp_actionscheduler_claims
    public class Wp_actionscheduler_claims
    {
        #region Member Variables
        protected unknown _claim_id;
        protected DateTime _date_created_gmt;
        #endregion
        #region Constructors
        public Wp_actionscheduler_claims() { }
        public Wp_actionscheduler_claims(DateTime date_created_gmt)
        {
            this._date_created_gmt=date_created_gmt;
        }
        #endregion
        #region Public Properties
        public virtual unknown Claim_id
        {
            get {return _claim_id;}
            set {_claim_id=value;}
        }
        public virtual DateTime Date_created_gmt
        {
            get {return _date_created_gmt;}
            set {_date_created_gmt=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Deawoo
{
    #region Wp_actionscheduler_groups
    public class Wp_actionscheduler_groups
    {
        #region Member Variables
        protected unknown _group_id;
        protected string _slug;
        #endregion
        #region Constructors
        public Wp_actionscheduler_groups() { }
        public Wp_actionscheduler_groups(string slug)
        {
            this._slug=slug;
        }
        #endregion
        #region Public Properties
        public virtual unknown Group_id
        {
            get {return _group_id;}
            set {_group_id=value;}
        }
        public virtual string Slug
        {
            get {return _slug;}
            set {_slug=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Deawoo
{
    #region Wp_actionscheduler_logs
    public class Wp_actionscheduler_logs
    {
        #region Member Variables
        protected unknown _log_id;
        protected unknown _action_id;
        protected string _message;
        protected DateTime _log_date_gmt;
        protected DateTime _log_date_local;
        #endregion
        #region Constructors
        public Wp_actionscheduler_logs() { }
        public Wp_actionscheduler_logs(unknown action_id, string message, DateTime log_date_gmt, DateTime log_date_local)
        {
            this._action_id=action_id;
            this._message=message;
            this._log_date_gmt=log_date_gmt;
            this._log_date_local=log_date_local;
        }
        #endregion
        #region Public Properties
        public virtual unknown Log_id
        {
            get {return _log_id;}
            set {_log_id=value;}
        }
        public virtual unknown Action_id
        {
            get {return _action_id;}
            set {_action_id=value;}
        }
        public virtual string Message
        {
            get {return _message;}
            set {_message=value;}
        }
        public virtual DateTime Log_date_gmt
        {
            get {return _log_date_gmt;}
            set {_log_date_gmt=value;}
        }
        public virtual DateTime Log_date_local
        {
            get {return _log_date_local;}
            set {_log_date_local=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Deawoo
{
    #region Wp_commentmeta
    public class Wp_commentmeta
    {
        #region Member Variables
        protected unknown _meta_id;
        protected unknown _comment_id;
        protected string _meta_key;
        protected string _meta_value;
        #endregion
        #region Constructors
        public Wp_commentmeta() { }
        public Wp_commentmeta(unknown comment_id, string meta_key, string meta_value)
        {
            this._comment_id=comment_id;
            this._meta_key=meta_key;
            this._meta_value=meta_value;
        }
        #endregion
        #region Public Properties
        public virtual unknown Meta_id
        {
            get {return _meta_id;}
            set {_meta_id=value;}
        }
        public virtual unknown Comment_id
        {
            get {return _comment_id;}
            set {_comment_id=value;}
        }
        public virtual string Meta_key
        {
            get {return _meta_key;}
            set {_meta_key=value;}
        }
        public virtual string Meta_value
        {
            get {return _meta_value;}
            set {_meta_value=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Deawoo
{
    #region Wp_comments
    public class Wp_comments
    {
        #region Member Variables
        protected unknown _comment_ID;
        protected unknown _comment_post_ID;
        protected unknown _comment_author;
        protected string _comment_author_email;
        protected string _comment_author_url;
        protected string _comment_author_IP;
        protected DateTime _comment_date;
        protected DateTime _comment_date_gmt;
        protected string _comment_content;
        protected int _comment_karma;
        protected string _comment_approved;
        protected string _comment_agent;
        protected string _comment_type;
        protected unknown _comment_parent;
        protected unknown _user_id;
        #endregion
        #region Constructors
        public Wp_comments() { }
        public Wp_comments(unknown comment_post_ID, unknown comment_author, string comment_author_email, string comment_author_url, string comment_author_IP, DateTime comment_date, DateTime comment_date_gmt, string comment_content, int comment_karma, string comment_approved, string comment_agent, string comment_type, unknown comment_parent, unknown user_id)
        {
            this._comment_post_ID=comment_post_ID;
            this._comment_author=comment_author;
            this._comment_author_email=comment_author_email;
            this._comment_author_url=comment_author_url;
            this._comment_author_IP=comment_author_IP;
            this._comment_date=comment_date;
            this._comment_date_gmt=comment_date_gmt;
            this._comment_content=comment_content;
            this._comment_karma=comment_karma;
            this._comment_approved=comment_approved;
            this._comment_agent=comment_agent;
            this._comment_type=comment_type;
            this._comment_parent=comment_parent;
            this._user_id=user_id;
        }
        #endregion
        #region Public Properties
        public virtual unknown Comment_ID
        {
            get {return _comment_ID;}
            set {_comment_ID=value;}
        }
        public virtual unknown Comment_post_ID
        {
            get {return _comment_post_ID;}
            set {_comment_post_ID=value;}
        }
        public virtual unknown Comment_author
        {
            get {return _comment_author;}
            set {_comment_author=value;}
        }
        public virtual string Comment_author_email
        {
            get {return _comment_author_email;}
            set {_comment_author_email=value;}
        }
        public virtual string Comment_author_url
        {
            get {return _comment_author_url;}
            set {_comment_author_url=value;}
        }
        public virtual string Comment_author_IP
        {
            get {return _comment_author_IP;}
            set {_comment_author_IP=value;}
        }
        public virtual DateTime Comment_date
        {
            get {return _comment_date;}
            set {_comment_date=value;}
        }
        public virtual DateTime Comment_date_gmt
        {
            get {return _comment_date_gmt;}
            set {_comment_date_gmt=value;}
        }
        public virtual string Comment_content
        {
            get {return _comment_content;}
            set {_comment_content=value;}
        }
        public virtual int Comment_karma
        {
            get {return _comment_karma;}
            set {_comment_karma=value;}
        }
        public virtual string Comment_approved
        {
            get {return _comment_approved;}
            set {_comment_approved=value;}
        }
        public virtual string Comment_agent
        {
            get {return _comment_agent;}
            set {_comment_agent=value;}
        }
        public virtual string Comment_type
        {
            get {return _comment_type;}
            set {_comment_type=value;}
        }
        public virtual unknown Comment_parent
        {
            get {return _comment_parent;}
            set {_comment_parent=value;}
        }
        public virtual unknown User_id
        {
            get {return _user_id;}
            set {_user_id=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Deawoo
{
    #region Wp_e_events
    public class Wp_e_events
    {
        #region Member Variables
        protected unknown _id;
        protected string _event_data;
        protected DateTime _created_at;
        #endregion
        #region Constructors
        public Wp_e_events() { }
        public Wp_e_events(string event_data, DateTime created_at)
        {
            this._event_data=event_data;
            this._created_at=created_at;
        }
        #endregion
        #region Public Properties
        public virtual unknown Id
        {
            get {return _id;}
            set {_id=value;}
        }
        public virtual string Event_data
        {
            get {return _event_data;}
            set {_event_data=value;}
        }
        public virtual DateTime Created_at
        {
            get {return _created_at;}
            set {_created_at=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Deawoo
{
    #region Wp_links
    public class Wp_links
    {
        #region Member Variables
        protected unknown _link_id;
        protected string _link_url;
        protected string _link_name;
        protected string _link_image;
        protected string _link_target;
        protected string _link_description;
        protected string _link_visible;
        protected unknown _link_owner;
        protected int _link_rating;
        protected DateTime _link_updated;
        protected string _link_rel;
        protected unknown _link_notes;
        protected string _link_rss;
        #endregion
        #region Constructors
        public Wp_links() { }
        public Wp_links(string link_url, string link_name, string link_image, string link_target, string link_description, string link_visible, unknown link_owner, int link_rating, DateTime link_updated, string link_rel, unknown link_notes, string link_rss)
        {
            this._link_url=link_url;
            this._link_name=link_name;
            this._link_image=link_image;
            this._link_target=link_target;
            this._link_description=link_description;
            this._link_visible=link_visible;
            this._link_owner=link_owner;
            this._link_rating=link_rating;
            this._link_updated=link_updated;
            this._link_rel=link_rel;
            this._link_notes=link_notes;
            this._link_rss=link_rss;
        }
        #endregion
        #region Public Properties
        public virtual unknown Link_id
        {
            get {return _link_id;}
            set {_link_id=value;}
        }
        public virtual string Link_url
        {
            get {return _link_url;}
            set {_link_url=value;}
        }
        public virtual string Link_name
        {
            get {return _link_name;}
            set {_link_name=value;}
        }
        public virtual string Link_image
        {
            get {return _link_image;}
            set {_link_image=value;}
        }
        public virtual string Link_target
        {
            get {return _link_target;}
            set {_link_target=value;}
        }
        public virtual string Link_description
        {
            get {return _link_description;}
            set {_link_description=value;}
        }
        public virtual string Link_visible
        {
            get {return _link_visible;}
            set {_link_visible=value;}
        }
        public virtual unknown Link_owner
        {
            get {return _link_owner;}
            set {_link_owner=value;}
        }
        public virtual int Link_rating
        {
            get {return _link_rating;}
            set {_link_rating=value;}
        }
        public virtual DateTime Link_updated
        {
            get {return _link_updated;}
            set {_link_updated=value;}
        }
        public virtual string Link_rel
        {
            get {return _link_rel;}
            set {_link_rel=value;}
        }
        public virtual unknown Link_notes
        {
            get {return _link_notes;}
            set {_link_notes=value;}
        }
        public virtual string Link_rss
        {
            get {return _link_rss;}
            set {_link_rss=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Deawoo
{
    #region Wp_options
    public class Wp_options
    {
        #region Member Variables
        protected unknown _option_id;
        protected string _option_name;
        protected string _option_value;
        protected string _autoload;
        #endregion
        #region Constructors
        public Wp_options() { }
        public Wp_options(string option_name, string option_value, string autoload)
        {
            this._option_name=option_name;
            this._option_value=option_value;
            this._autoload=autoload;
        }
        #endregion
        #region Public Properties
        public virtual unknown Option_id
        {
            get {return _option_id;}
            set {_option_id=value;}
        }
        public virtual string Option_name
        {
            get {return _option_name;}
            set {_option_name=value;}
        }
        public virtual string Option_value
        {
            get {return _option_value;}
            set {_option_value=value;}
        }
        public virtual string Autoload
        {
            get {return _autoload;}
            set {_autoload=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Deawoo
{
    #region Wp_postmeta
    public class Wp_postmeta
    {
        #region Member Variables
        protected unknown _meta_id;
        protected unknown _post_id;
        protected string _meta_key;
        protected string _meta_value;
        #endregion
        #region Constructors
        public Wp_postmeta() { }
        public Wp_postmeta(unknown post_id, string meta_key, string meta_value)
        {
            this._post_id=post_id;
            this._meta_key=meta_key;
            this._meta_value=meta_value;
        }
        #endregion
        #region Public Properties
        public virtual unknown Meta_id
        {
            get {return _meta_id;}
            set {_meta_id=value;}
        }
        public virtual unknown Post_id
        {
            get {return _post_id;}
            set {_post_id=value;}
        }
        public virtual string Meta_key
        {
            get {return _meta_key;}
            set {_meta_key=value;}
        }
        public virtual string Meta_value
        {
            get {return _meta_value;}
            set {_meta_value=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Deawoo
{
    #region Wp_posts
    public class Wp_posts
    {
        #region Member Variables
        protected unknown _ID;
        protected unknown _post_author;
        protected DateTime _post_date;
        protected DateTime _post_date_gmt;
        protected string _post_content;
        protected string _post_title;
        protected string _post_excerpt;
        protected string _post_status;
        protected string _comment_status;
        protected string _ping_status;
        protected string _post_password;
        protected string _post_name;
        protected string _to_ping;
        protected string _pinged;
        protected DateTime _post_modified;
        protected DateTime _post_modified_gmt;
        protected string _post_content_filtered;
        protected unknown _post_parent;
        protected string _guid;
        protected int _menu_order;
        protected string _post_type;
        protected string _post_mime_type;
        protected unknown _comment_count;
        #endregion
        #region Constructors
        public Wp_posts() { }
        public Wp_posts(unknown post_author, DateTime post_date, DateTime post_date_gmt, string post_content, string post_title, string post_excerpt, string post_status, string comment_status, string ping_status, string post_password, string post_name, string to_ping, string pinged, DateTime post_modified, DateTime post_modified_gmt, string post_content_filtered, unknown post_parent, string guid, int menu_order, string post_type, string post_mime_type, unknown comment_count)
        {
            this._post_author=post_author;
            this._post_date=post_date;
            this._post_date_gmt=post_date_gmt;
            this._post_content=post_content;
            this._post_title=post_title;
            this._post_excerpt=post_excerpt;
            this._post_status=post_status;
            this._comment_status=comment_status;
            this._ping_status=ping_status;
            this._post_password=post_password;
            this._post_name=post_name;
            this._to_ping=to_ping;
            this._pinged=pinged;
            this._post_modified=post_modified;
            this._post_modified_gmt=post_modified_gmt;
            this._post_content_filtered=post_content_filtered;
            this._post_parent=post_parent;
            this._guid=guid;
            this._menu_order=menu_order;
            this._post_type=post_type;
            this._post_mime_type=post_mime_type;
            this._comment_count=comment_count;
        }
        #endregion
        #region Public Properties
        public virtual unknown ID
        {
            get {return _ID;}
            set {_ID=value;}
        }
        public virtual unknown Post_author
        {
            get {return _post_author;}
            set {_post_author=value;}
        }
        public virtual DateTime Post_date
        {
            get {return _post_date;}
            set {_post_date=value;}
        }
        public virtual DateTime Post_date_gmt
        {
            get {return _post_date_gmt;}
            set {_post_date_gmt=value;}
        }
        public virtual string Post_content
        {
            get {return _post_content;}
            set {_post_content=value;}
        }
        public virtual string Post_title
        {
            get {return _post_title;}
            set {_post_title=value;}
        }
        public virtual string Post_excerpt
        {
            get {return _post_excerpt;}
            set {_post_excerpt=value;}
        }
        public virtual string Post_status
        {
            get {return _post_status;}
            set {_post_status=value;}
        }
        public virtual string Comment_status
        {
            get {return _comment_status;}
            set {_comment_status=value;}
        }
        public virtual string Ping_status
        {
            get {return _ping_status;}
            set {_ping_status=value;}
        }
        public virtual string Post_password
        {
            get {return _post_password;}
            set {_post_password=value;}
        }
        public virtual string Post_name
        {
            get {return _post_name;}
            set {_post_name=value;}
        }
        public virtual string To_ping
        {
            get {return _to_ping;}
            set {_to_ping=value;}
        }
        public virtual string Pinged
        {
            get {return _pinged;}
            set {_pinged=value;}
        }
        public virtual DateTime Post_modified
        {
            get {return _post_modified;}
            set {_post_modified=value;}
        }
        public virtual DateTime Post_modified_gmt
        {
            get {return _post_modified_gmt;}
            set {_post_modified_gmt=value;}
        }
        public virtual string Post_content_filtered
        {
            get {return _post_content_filtered;}
            set {_post_content_filtered=value;}
        }
        public virtual unknown Post_parent
        {
            get {return _post_parent;}
            set {_post_parent=value;}
        }
        public virtual string Guid
        {
            get {return _guid;}
            set {_guid=value;}
        }
        public virtual int Menu_order
        {
            get {return _menu_order;}
            set {_menu_order=value;}
        }
        public virtual string Post_type
        {
            get {return _post_type;}
            set {_post_type=value;}
        }
        public virtual string Post_mime_type
        {
            get {return _post_mime_type;}
            set {_post_mime_type=value;}
        }
        public virtual unknown Comment_count
        {
            get {return _comment_count;}
            set {_comment_count=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Deawoo
{
    #region Wp_rank_math__logs
    public class Wp_rank_math__logs
    {
        #region Member Variables
        protected unknown _id;
        protected string _uri;
        protected DateTime _accessed;
        protected unknown _times_accessed;
        protected string _referer;
        protected string _user_agent;
        #endregion
        #region Constructors
        public Wp_rank_math__logs() { }
        public Wp_rank_math__logs(string uri, DateTime accessed, unknown times_accessed, string referer, string user_agent)
        {
            this._uri=uri;
            this._accessed=accessed;
            this._times_accessed=times_accessed;
            this._referer=referer;
            this._user_agent=user_agent;
        }
        #endregion
        #region Public Properties
        public virtual unknown Id
        {
            get {return _id;}
            set {_id=value;}
        }
        public virtual string Uri
        {
            get {return _uri;}
            set {_uri=value;}
        }
        public virtual DateTime Accessed
        {
            get {return _accessed;}
            set {_accessed=value;}
        }
        public virtual unknown Times_accessed
        {
            get {return _times_accessed;}
            set {_times_accessed=value;}
        }
        public virtual string Referer
        {
            get {return _referer;}
            set {_referer=value;}
        }
        public virtual string User_agent
        {
            get {return _user_agent;}
            set {_user_agent=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Deawoo
{
    #region Wp_rank_math_analytics_gsc
    public class Wp_rank_math_analytics_gsc
    {
        #region Member Variables
        protected unknown _id;
        protected unknown _created;
        protected string _query;
        protected string _page;
        protected unknown _clicks;
        protected unknown _impressions;
        protected unknown _position;
        protected unknown _ctr;
        #endregion
        #region Constructors
        public Wp_rank_math_analytics_gsc() { }
        public Wp_rank_math_analytics_gsc(unknown created, string query, string page, unknown clicks, unknown impressions, unknown position, unknown ctr)
        {
            this._created=created;
            this._query=query;
            this._page=page;
            this._clicks=clicks;
            this._impressions=impressions;
            this._position=position;
            this._ctr=ctr;
        }
        #endregion
        #region Public Properties
        public virtual unknown Id
        {
            get {return _id;}
            set {_id=value;}
        }
        public virtual unknown Created
        {
            get {return _created;}
            set {_created=value;}
        }
        public virtual string Query
        {
            get {return _query;}
            set {_query=value;}
        }
        public virtual string Page
        {
            get {return _page;}
            set {_page=value;}
        }
        public virtual unknown Clicks
        {
            get {return _clicks;}
            set {_clicks=value;}
        }
        public virtual unknown Impressions
        {
            get {return _impressions;}
            set {_impressions=value;}
        }
        public virtual unknown Position
        {
            get {return _position;}
            set {_position=value;}
        }
        public virtual unknown Ctr
        {
            get {return _ctr;}
            set {_ctr=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Deawoo
{
    #region Wp_rank_math_analytics_inspections
    public class Wp_rank_math_analytics_inspections
    {
        #region Member Variables
        protected unknown _id;
        protected string _page;
        protected unknown _created;
        protected string _index_verdict;
        protected string _indexing_state;
        protected string _coverage_state;
        protected string _page_fetch_state;
        protected string _robots_txt_state;
        protected string _rich_results_verdict;
        protected string _rich_results_items;
        protected unknown _last_crawl_time;
        protected string _crawled_as;
        protected string _google_canonical;
        protected string _user_canonical;
        protected string _sitemap;
        protected string _referring_urls;
        protected string _raw_api_response;
        #endregion
        #region Constructors
        public Wp_rank_math_analytics_inspections() { }
        public Wp_rank_math_analytics_inspections(string page, unknown created, string index_verdict, string indexing_state, string coverage_state, string page_fetch_state, string robots_txt_state, string rich_results_verdict, string rich_results_items, unknown last_crawl_time, string crawled_as, string google_canonical, string user_canonical, string sitemap, string referring_urls, string raw_api_response)
        {
            this._page=page;
            this._created=created;
            this._index_verdict=index_verdict;
            this._indexing_state=indexing_state;
            this._coverage_state=coverage_state;
            this._page_fetch_state=page_fetch_state;
            this._robots_txt_state=robots_txt_state;
            this._rich_results_verdict=rich_results_verdict;
            this._rich_results_items=rich_results_items;
            this._last_crawl_time=last_crawl_time;
            this._crawled_as=crawled_as;
            this._google_canonical=google_canonical;
            this._user_canonical=user_canonical;
            this._sitemap=sitemap;
            this._referring_urls=referring_urls;
            this._raw_api_response=raw_api_response;
        }
        #endregion
        #region Public Properties
        public virtual unknown Id
        {
            get {return _id;}
            set {_id=value;}
        }
        public virtual string Page
        {
            get {return _page;}
            set {_page=value;}
        }
        public virtual unknown Created
        {
            get {return _created;}
            set {_created=value;}
        }
        public virtual string Index_verdict
        {
            get {return _index_verdict;}
            set {_index_verdict=value;}
        }
        public virtual string Indexing_state
        {
            get {return _indexing_state;}
            set {_indexing_state=value;}
        }
        public virtual string Coverage_state
        {
            get {return _coverage_state;}
            set {_coverage_state=value;}
        }
        public virtual string Page_fetch_state
        {
            get {return _page_fetch_state;}
            set {_page_fetch_state=value;}
        }
        public virtual string Robots_txt_state
        {
            get {return _robots_txt_state;}
            set {_robots_txt_state=value;}
        }
        public virtual string Rich_results_verdict
        {
            get {return _rich_results_verdict;}
            set {_rich_results_verdict=value;}
        }
        public virtual string Rich_results_items
        {
            get {return _rich_results_items;}
            set {_rich_results_items=value;}
        }
        public virtual unknown Last_crawl_time
        {
            get {return _last_crawl_time;}
            set {_last_crawl_time=value;}
        }
        public virtual string Crawled_as
        {
            get {return _crawled_as;}
            set {_crawled_as=value;}
        }
        public virtual string Google_canonical
        {
            get {return _google_canonical;}
            set {_google_canonical=value;}
        }
        public virtual string User_canonical
        {
            get {return _user_canonical;}
            set {_user_canonical=value;}
        }
        public virtual string Sitemap
        {
            get {return _sitemap;}
            set {_sitemap=value;}
        }
        public virtual string Referring_urls
        {
            get {return _referring_urls;}
            set {_referring_urls=value;}
        }
        public virtual string Raw_api_response
        {
            get {return _raw_api_response;}
            set {_raw_api_response=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Deawoo
{
    #region Wp_rank_math_analytics_objects
    public class Wp_rank_math_analytics_objects
    {
        #region Member Variables
        protected unknown _id;
        protected unknown _created;
        protected string _title;
        protected string _page;
        protected string _object_type;
        protected string _object_subtype;
        protected unknown _object_id;
        protected string _primary_key;
        protected bool _seo_score;
        protected bool _page_score;
        protected bool _is_indexable;
        protected string _schemas_in_use;
        protected unknown _desktop_interactive;
        protected unknown _desktop_pagescore;
        protected unknown _mobile_interactive;
        protected unknown _mobile_pagescore;
        protected unknown _pagespeed_refreshed;
        #endregion
        #region Constructors
        public Wp_rank_math_analytics_objects() { }
        public Wp_rank_math_analytics_objects(unknown created, string title, string page, string object_type, string object_subtype, unknown object_id, string primary_key, bool seo_score, bool page_score, bool is_indexable, string schemas_in_use, unknown desktop_interactive, unknown desktop_pagescore, unknown mobile_interactive, unknown mobile_pagescore, unknown pagespeed_refreshed)
        {
            this._created=created;
            this._title=title;
            this._page=page;
            this._object_type=object_type;
            this._object_subtype=object_subtype;
            this._object_id=object_id;
            this._primary_key=primary_key;
            this._seo_score=seo_score;
            this._page_score=page_score;
            this._is_indexable=is_indexable;
            this._schemas_in_use=schemas_in_use;
            this._desktop_interactive=desktop_interactive;
            this._desktop_pagescore=desktop_pagescore;
            this._mobile_interactive=mobile_interactive;
            this._mobile_pagescore=mobile_pagescore;
            this._pagespeed_refreshed=pagespeed_refreshed;
        }
        #endregion
        #region Public Properties
        public virtual unknown Id
        {
            get {return _id;}
            set {_id=value;}
        }
        public virtual unknown Created
        {
            get {return _created;}
            set {_created=value;}
        }
        public virtual string Title
        {
            get {return _title;}
            set {_title=value;}
        }
        public virtual string Page
        {
            get {return _page;}
            set {_page=value;}
        }
        public virtual string Object_type
        {
            get {return _object_type;}
            set {_object_type=value;}
        }
        public virtual string Object_subtype
        {
            get {return _object_subtype;}
            set {_object_subtype=value;}
        }
        public virtual unknown Object_id
        {
            get {return _object_id;}
            set {_object_id=value;}
        }
        public virtual string Primary_key
        {
            get {return _primary_key;}
            set {_primary_key=value;}
        }
        public virtual bool Seo_score
        {
            get {return _seo_score;}
            set {_seo_score=value;}
        }
        public virtual bool Page_score
        {
            get {return _page_score;}
            set {_page_score=value;}
        }
        public virtual bool Is_indexable
        {
            get {return _is_indexable;}
            set {_is_indexable=value;}
        }
        public virtual string Schemas_in_use
        {
            get {return _schemas_in_use;}
            set {_schemas_in_use=value;}
        }
        public virtual unknown Desktop_interactive
        {
            get {return _desktop_interactive;}
            set {_desktop_interactive=value;}
        }
        public virtual unknown Desktop_pagescore
        {
            get {return _desktop_pagescore;}
            set {_desktop_pagescore=value;}
        }
        public virtual unknown Mobile_interactive
        {
            get {return _mobile_interactive;}
            set {_mobile_interactive=value;}
        }
        public virtual unknown Mobile_pagescore
        {
            get {return _mobile_pagescore;}
            set {_mobile_pagescore=value;}
        }
        public virtual unknown Pagespeed_refreshed
        {
            get {return _pagespeed_refreshed;}
            set {_pagespeed_refreshed=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Deawoo
{
    #region Wp_rank_math_internal_links
    public class Wp_rank_math_internal_links
    {
        #region Member Variables
        protected unknown _id;
        protected string _url;
        protected unknown _post_id;
        protected unknown _target_post_id;
        protected string _type;
        #endregion
        #region Constructors
        public Wp_rank_math_internal_links() { }
        public Wp_rank_math_internal_links(string url, unknown post_id, unknown target_post_id, string type)
        {
            this._url=url;
            this._post_id=post_id;
            this._target_post_id=target_post_id;
            this._type=type;
        }
        #endregion
        #region Public Properties
        public virtual unknown Id
        {
            get {return _id;}
            set {_id=value;}
        }
        public virtual string Url
        {
            get {return _url;}
            set {_url=value;}
        }
        public virtual unknown Post_id
        {
            get {return _post_id;}
            set {_post_id=value;}
        }
        public virtual unknown Target_post_id
        {
            get {return _target_post_id;}
            set {_target_post_id=value;}
        }
        public virtual string Type
        {
            get {return _type;}
            set {_type=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Deawoo
{
    #region Wp_rank_math_internal_meta
    public class Wp_rank_math_internal_meta
    {
        #region Member Variables
        protected unknown _object_id;
        protected int _internal_link_count;
        protected int _external_link_count;
        protected int _incoming_link_count;
        #endregion
        #region Constructors
        public Wp_rank_math_internal_meta() { }
        public Wp_rank_math_internal_meta(int internal_link_count, int external_link_count, int incoming_link_count)
        {
            this._internal_link_count=internal_link_count;
            this._external_link_count=external_link_count;
            this._incoming_link_count=incoming_link_count;
        }
        #endregion
        #region Public Properties
        public virtual unknown Object_id
        {
            get {return _object_id;}
            set {_object_id=value;}
        }
        public virtual int Internal_link_count
        {
            get {return _internal_link_count;}
            set {_internal_link_count=value;}
        }
        public virtual int External_link_count
        {
            get {return _external_link_count;}
            set {_external_link_count=value;}
        }
        public virtual int Incoming_link_count
        {
            get {return _incoming_link_count;}
            set {_incoming_link_count=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Deawoo
{
    #region Wp_termmeta
    public class Wp_termmeta
    {
        #region Member Variables
        protected unknown _meta_id;
        protected unknown _term_id;
        protected string _meta_key;
        protected string _meta_value;
        #endregion
        #region Constructors
        public Wp_termmeta() { }
        public Wp_termmeta(unknown term_id, string meta_key, string meta_value)
        {
            this._term_id=term_id;
            this._meta_key=meta_key;
            this._meta_value=meta_value;
        }
        #endregion
        #region Public Properties
        public virtual unknown Meta_id
        {
            get {return _meta_id;}
            set {_meta_id=value;}
        }
        public virtual unknown Term_id
        {
            get {return _term_id;}
            set {_term_id=value;}
        }
        public virtual string Meta_key
        {
            get {return _meta_key;}
            set {_meta_key=value;}
        }
        public virtual string Meta_value
        {
            get {return _meta_value;}
            set {_meta_value=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Deawoo
{
    #region Wp_terms
    public class Wp_terms
    {
        #region Member Variables
        protected unknown _term_id;
        protected string _name;
        protected string _slug;
        protected unknown _term_group;
        #endregion
        #region Constructors
        public Wp_terms() { }
        public Wp_terms(string name, string slug, unknown term_group)
        {
            this._name=name;
            this._slug=slug;
            this._term_group=term_group;
        }
        #endregion
        #region Public Properties
        public virtual unknown Term_id
        {
            get {return _term_id;}
            set {_term_id=value;}
        }
        public virtual string Name
        {
            get {return _name;}
            set {_name=value;}
        }
        public virtual string Slug
        {
            get {return _slug;}
            set {_slug=value;}
        }
        public virtual unknown Term_group
        {
            get {return _term_group;}
            set {_term_group=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Deawoo
{
    #region Wp_term_relationships
    public class Wp_term_relationships
    {
        #region Member Variables
        protected unknown _object_id;
        protected unknown _term_taxonomy_id;
        protected int _term_order;
        #endregion
        #region Constructors
        public Wp_term_relationships() { }
        public Wp_term_relationships(int term_order)
        {
            this._term_order=term_order;
        }
        #endregion
        #region Public Properties
        public virtual unknown Object_id
        {
            get {return _object_id;}
            set {_object_id=value;}
        }
        public virtual unknown Term_taxonomy_id
        {
            get {return _term_taxonomy_id;}
            set {_term_taxonomy_id=value;}
        }
        public virtual int Term_order
        {
            get {return _term_order;}
            set {_term_order=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Deawoo
{
    #region Wp_term_taxonomy
    public class Wp_term_taxonomy
    {
        #region Member Variables
        protected unknown _term_taxonomy_id;
        protected unknown _term_id;
        protected string _taxonomy;
        protected string _description;
        protected unknown _parent;
        protected unknown _count;
        #endregion
        #region Constructors
        public Wp_term_taxonomy() { }
        public Wp_term_taxonomy(unknown term_id, string taxonomy, string description, unknown parent, unknown count)
        {
            this._term_id=term_id;
            this._taxonomy=taxonomy;
            this._description=description;
            this._parent=parent;
            this._count=count;
        }
        #endregion
        #region Public Properties
        public virtual unknown Term_taxonomy_id
        {
            get {return _term_taxonomy_id;}
            set {_term_taxonomy_id=value;}
        }
        public virtual unknown Term_id
        {
            get {return _term_id;}
            set {_term_id=value;}
        }
        public virtual string Taxonomy
        {
            get {return _taxonomy;}
            set {_taxonomy=value;}
        }
        public virtual string Description
        {
            get {return _description;}
            set {_description=value;}
        }
        public virtual unknown Parent
        {
            get {return _parent;}
            set {_parent=value;}
        }
        public virtual unknown Count
        {
            get {return _count;}
            set {_count=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Deawoo
{
    #region Wp_usermeta
    public class Wp_usermeta
    {
        #region Member Variables
        protected unknown _umeta_id;
        protected unknown _user_id;
        protected string _meta_key;
        protected string _meta_value;
        #endregion
        #region Constructors
        public Wp_usermeta() { }
        public Wp_usermeta(unknown user_id, string meta_key, string meta_value)
        {
            this._user_id=user_id;
            this._meta_key=meta_key;
            this._meta_value=meta_value;
        }
        #endregion
        #region Public Properties
        public virtual unknown Umeta_id
        {
            get {return _umeta_id;}
            set {_umeta_id=value;}
        }
        public virtual unknown User_id
        {
            get {return _user_id;}
            set {_user_id=value;}
        }
        public virtual string Meta_key
        {
            get {return _meta_key;}
            set {_meta_key=value;}
        }
        public virtual string Meta_value
        {
            get {return _meta_value;}
            set {_meta_value=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Deawoo
{
    #region Wp_users
    public class Wp_users
    {
        #region Member Variables
        protected unknown _ID;
        protected string _user_login;
        protected string _user_pass;
        protected string _user_nicename;
        protected string _user_email;
        protected string _user_url;
        protected DateTime _user_registered;
        protected string _user_activation_key;
        protected int _user_status;
        protected string _display_name;
        #endregion
        #region Constructors
        public Wp_users() { }
        public Wp_users(string user_login, string user_pass, string user_nicename, string user_email, string user_url, DateTime user_registered, string user_activation_key, int user_status, string display_name)
        {
            this._user_login=user_login;
            this._user_pass=user_pass;
            this._user_nicename=user_nicename;
            this._user_email=user_email;
            this._user_url=user_url;
            this._user_registered=user_registered;
            this._user_activation_key=user_activation_key;
            this._user_status=user_status;
            this._display_name=display_name;
        }
        #endregion
        #region Public Properties
        public virtual unknown ID
        {
            get {return _ID;}
            set {_ID=value;}
        }
        public virtual string User_login
        {
            get {return _user_login;}
            set {_user_login=value;}
        }
        public virtual string User_pass
        {
            get {return _user_pass;}
            set {_user_pass=value;}
        }
        public virtual string User_nicename
        {
            get {return _user_nicename;}
            set {_user_nicename=value;}
        }
        public virtual string User_email
        {
            get {return _user_email;}
            set {_user_email=value;}
        }
        public virtual string User_url
        {
            get {return _user_url;}
            set {_user_url=value;}
        }
        public virtual DateTime User_registered
        {
            get {return _user_registered;}
            set {_user_registered=value;}
        }
        public virtual string User_activation_key
        {
            get {return _user_activation_key;}
            set {_user_activation_key=value;}
        }
        public virtual int User_status
        {
            get {return _user_status;}
            set {_user_status=value;}
        }
        public virtual string Display_name
        {
            get {return _display_name;}
            set {_display_name=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Deawoo
{
    #region Wp_wpforms_logs
    public class Wp_wpforms_logs
    {
        #region Member Variables
        protected unknown _id;
        protected string _title;
        protected string _message;
        protected string _types;
        protected DateTime _create_at;
        protected unknown _form_id;
        protected unknown _entry_id;
        protected unknown _user_id;
        #endregion
        #region Constructors
        public Wp_wpforms_logs() { }
        public Wp_wpforms_logs(string title, string message, string types, DateTime create_at, unknown form_id, unknown entry_id, unknown user_id)
        {
            this._title=title;
            this._message=message;
            this._types=types;
            this._create_at=create_at;
            this._form_id=form_id;
            this._entry_id=entry_id;
            this._user_id=user_id;
        }
        #endregion
        #region Public Properties
        public virtual unknown Id
        {
            get {return _id;}
            set {_id=value;}
        }
        public virtual string Title
        {
            get {return _title;}
            set {_title=value;}
        }
        public virtual string Message
        {
            get {return _message;}
            set {_message=value;}
        }
        public virtual string Types
        {
            get {return _types;}
            set {_types=value;}
        }
        public virtual DateTime Create_at
        {
            get {return _create_at;}
            set {_create_at=value;}
        }
        public virtual unknown Form_id
        {
            get {return _form_id;}
            set {_form_id=value;}
        }
        public virtual unknown Entry_id
        {
            get {return _entry_id;}
            set {_entry_id=value;}
        }
        public virtual unknown User_id
        {
            get {return _user_id;}
            set {_user_id=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Deawoo
{
    #region Wp_wpforms_payments
    public class Wp_wpforms_payments
    {
        #region Member Variables
        protected unknown _id;
        protected unknown _form_id;
        protected string _status;
        protected unknown _subtotal_amount;
        protected unknown _discount_amount;
        protected unknown _total_amount;
        protected string _currency;
        protected unknown _entry_id;
        protected string _gateway;
        protected string _type;
        protected string _mode;
        protected string _transaction_id;
        protected string _customer_id;
        protected string _subscription_id;
        protected string _subscription_status;
        protected string _title;
        protected DateTime _date_created_gmt;
        protected DateTime _date_updated_gmt;
        protected bool _is_published;
        #endregion
        #region Constructors
        public Wp_wpforms_payments() { }
        public Wp_wpforms_payments(unknown form_id, string status, unknown subtotal_amount, unknown discount_amount, unknown total_amount, string currency, unknown entry_id, string gateway, string type, string mode, string transaction_id, string customer_id, string subscription_id, string subscription_status, string title, DateTime date_created_gmt, DateTime date_updated_gmt, bool is_published)
        {
            this._form_id=form_id;
            this._status=status;
            this._subtotal_amount=subtotal_amount;
            this._discount_amount=discount_amount;
            this._total_amount=total_amount;
            this._currency=currency;
            this._entry_id=entry_id;
            this._gateway=gateway;
            this._type=type;
            this._mode=mode;
            this._transaction_id=transaction_id;
            this._customer_id=customer_id;
            this._subscription_id=subscription_id;
            this._subscription_status=subscription_status;
            this._title=title;
            this._date_created_gmt=date_created_gmt;
            this._date_updated_gmt=date_updated_gmt;
            this._is_published=is_published;
        }
        #endregion
        #region Public Properties
        public virtual unknown Id
        {
            get {return _id;}
            set {_id=value;}
        }
        public virtual unknown Form_id
        {
            get {return _form_id;}
            set {_form_id=value;}
        }
        public virtual string Status
        {
            get {return _status;}
            set {_status=value;}
        }
        public virtual unknown Subtotal_amount
        {
            get {return _subtotal_amount;}
            set {_subtotal_amount=value;}
        }
        public virtual unknown Discount_amount
        {
            get {return _discount_amount;}
            set {_discount_amount=value;}
        }
        public virtual unknown Total_amount
        {
            get {return _total_amount;}
            set {_total_amount=value;}
        }
        public virtual string Currency
        {
            get {return _currency;}
            set {_currency=value;}
        }
        public virtual unknown Entry_id
        {
            get {return _entry_id;}
            set {_entry_id=value;}
        }
        public virtual string Gateway
        {
            get {return _gateway;}
            set {_gateway=value;}
        }
        public virtual string Type
        {
            get {return _type;}
            set {_type=value;}
        }
        public virtual string Mode
        {
            get {return _mode;}
            set {_mode=value;}
        }
        public virtual string Transaction_id
        {
            get {return _transaction_id;}
            set {_transaction_id=value;}
        }
        public virtual string Customer_id
        {
            get {return _customer_id;}
            set {_customer_id=value;}
        }
        public virtual string Subscription_id
        {
            get {return _subscription_id;}
            set {_subscription_id=value;}
        }
        public virtual string Subscription_status
        {
            get {return _subscription_status;}
            set {_subscription_status=value;}
        }
        public virtual string Title
        {
            get {return _title;}
            set {_title=value;}
        }
        public virtual DateTime Date_created_gmt
        {
            get {return _date_created_gmt;}
            set {_date_created_gmt=value;}
        }
        public virtual DateTime Date_updated_gmt
        {
            get {return _date_updated_gmt;}
            set {_date_updated_gmt=value;}
        }
        public virtual bool Is_published
        {
            get {return _is_published;}
            set {_is_published=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Deawoo
{
    #region Wp_wpforms_payment_meta
    public class Wp_wpforms_payment_meta
    {
        #region Member Variables
        protected unknown _id;
        protected unknown _payment_id;
        protected string _meta_key;
        protected string _meta_value;
        #endregion
        #region Constructors
        public Wp_wpforms_payment_meta() { }
        public Wp_wpforms_payment_meta(unknown payment_id, string meta_key, string meta_value)
        {
            this._payment_id=payment_id;
            this._meta_key=meta_key;
            this._meta_value=meta_value;
        }
        #endregion
        #region Public Properties
        public virtual unknown Id
        {
            get {return _id;}
            set {_id=value;}
        }
        public virtual unknown Payment_id
        {
            get {return _payment_id;}
            set {_payment_id=value;}
        }
        public virtual string Meta_key
        {
            get {return _meta_key;}
            set {_meta_key=value;}
        }
        public virtual string Meta_value
        {
            get {return _meta_value;}
            set {_meta_value=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Deawoo
{
    #region Wp_wpforms_tasks_meta
    public class Wp_wpforms_tasks_meta
    {
        #region Member Variables
        protected unknown _id;
        protected string _action;
        protected string _data;
        protected DateTime _date;
        #endregion
        #region Constructors
        public Wp_wpforms_tasks_meta() { }
        public Wp_wpforms_tasks_meta(string action, string data, DateTime date)
        {
            this._action=action;
            this._data=data;
            this._date=date;
        }
        #endregion
        #region Public Properties
        public virtual unknown Id
        {
            get {return _id;}
            set {_id=value;}
        }
        public virtual string Action
        {
            get {return _action;}
            set {_action=value;}
        }
        public virtual string Data
        {
            get {return _data;}
            set {_data=value;}
        }
        public virtual DateTime Date
        {
            get {return _date;}
            set {_date=value;}
        }
        #endregion
    }
    #endregion
}