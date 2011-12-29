using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Google.Apis.Authentication.OAuth2.DotNetOpenAuth;
using Google.Apis.Authentication.OAuth2;
using DotNetOpenAuth.OAuth2;
using Google.Apis.Plus.v1;
using System.Diagnostics;
using Google.Apis.Plus.v1.Data;

namespace com.xu81.dotnet.gplusplus
{
    class AppController
    {
        const string CLIENTIDENTIFIER = "365448355404.apps.googleusercontent.com";
        const string CLIENTSECRET = "2_p99Vme9ts4dhnicYje4qXb";
        const string AUTHURI = "https://www.googleapis.com/auth/plus.me";
        const string NOTENAME = "gplus_note.html";
        const string ACCESSTOKEN = "AIzaSyBMaTZib4FgvBru3DZ4f0ZV5q4080jpYZE";

        static NativeApplicationClient provider;
        
        /// <summary>
        /// authcode
        /// </summary>
        public static string authcode { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public static string userid { get; set; }

        /// <summary>
        /// 是否自动刷新
        /// </summary>
        public static bool autoRefresh { get; set; }

        /// <summary>
        /// 刷新延迟，单位秒
        /// </summary>
        public static int refreshDelay { get; set; }

        /// <summary>
        /// 笔记保存路径
        /// </summary>
        public static string notePath { get; set; }

        public static void AppExit()
        {
            Application.Exit();
        }
        
        /// <summary>
        /// OAuth验证方法
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        private static IAuthorizationState GetAuthorization(NativeApplicationClient arg)
        {
            IAuthorizationState state = new AuthorizationState(new[] { AUTHURI });
            state.Callback = new Uri(NativeApplicationClient.OutOfBandCallbackUrl);
            state.AccessToken = ACCESSTOKEN;
            Uri authUri = arg.RequestUserAuthorization(state);
            return arg.ProcessUserAuthorization(authcode);
        }

        /// <summary>
        /// 初始化NativeApplicationClient provider
        /// </summary>
        private static void InitProvider()
        {
            if (provider == null)
            {
                provider = new NativeApplicationClient(GoogleAuthenticationServer.Description);
            }
            provider.ClientIdentifier = CLIENTIDENTIFIER;
            provider.ClientSecret = CLIENTSECRET;
        }

        /// <summary>
        /// 获取authcode
        /// </summary>
        public static void GetAuthCode()
        {
            InitProvider();

            IAuthorizationState state = new AuthorizationState(new[] { AUTHURI });
            state.Callback = new Uri(NativeApplicationClient.OutOfBandCallbackUrl);
            state.AccessToken = ACCESSTOKEN;
            Uri authUri = provider.RequestUserAuthorization(state);
            Process.Start(authUri.ToString());
        }

        /// <summary>
        /// 验证authcode和userid是否正确
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public static bool VerifyAuthCode()
        {
            InitProvider();
            OAuth2Authenticator<NativeApplicationClient> auth = new OAuth2Authenticator<NativeApplicationClient>(provider, GetAuthorization);
            PlusService service = new PlusService(auth);
            Person person = service.People.Get(userid).Fetch();
            return person.DisplayName!=null && person.DisplayName.Length>0;
        }

        public static void getActivities()
        {
            InitProvider();
            OAuth2Authenticator<NativeApplicationClient> auth = new OAuth2Authenticator<NativeApplicationClient>(provider, GetAuthorization);

            PlusService service = new PlusService(auth);
            ActivityFeed list = service.Activities.List(userid, ActivitiesResource.Collection.Public).Fetch();
            Console.Write("2    " + list.Title);
        }
    }
}
