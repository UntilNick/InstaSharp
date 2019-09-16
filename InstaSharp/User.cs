using System;
using Newtonsoft.Json.Linq;

namespace InstaSharp
{
    public class User
    {
        /// <summary>
        /// Get User's ID
        /// </summary>
        /// <param name="Username">Username of the user to retrieve</param>
        /// <returns>User ID</returns>
        public static int GetUserID(string Username)
        {
            try
            {
                JObject UserData = Parser.ParseUserData(Username);
                return UserData["graphql"]["user"]["id"].Value<int>();
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Gets user's username
        /// </summary>
        /// <param name="Username">Username of the user to retrieve</param>
        /// <returns>Username</returns>
        public static string GetUserName(string Username)
        {
            try
            {
                JObject UserData = Parser.ParseUserData(Username);
                return UserData["graphql"]["user"]["username"].Value<string>();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        /// <summary>
        /// Gets user's fullname
        /// </summary>
        /// <param name="Username">Username of the user to retrieve</param>
        /// <returns>Fullname</returns>
        public static string GetFullName(string Username)
        {
            try
            {
                JObject UserData = Parser.ParseUserData(Username);
                return UserData["graphql"]["user"]["full_name"].Value<string>();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        /// <summary>
        /// Checks if user has a Youtube channel linked
        /// </summary>
        /// <param name="Username">Username of the user to retrieve</param>
        /// <returns>Bool</returns>
        public static bool HasChannel(string Username)
        {
            try
            {
                JObject UserData = Parser.ParseUserData(Username);
                return UserData["graphql"]["user"]["has_channel"].Value<bool>();
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Gets user's biography
        /// </summary>
        /// <param name="Username">Username of the user to retrieve</param>
        /// <returns>Biography</returns>
        public static string GetBiography(string Username)
        {
            try
            {
                JObject UserData = Parser.ParseUserData(Username);
                return UserData["graphql"]["user"]["biography"].Value<string>();
            }
            catch(Exception ex)
            {
                return ex.ToString();
            }
        }

        /// <summary>
        /// Gets user's profile picture
        /// </summary>
        /// <param name="Username">Username of the user to retrieve</param>
        /// <returns>Profile Picture</returns>
        public static string GetProfilePicture(string Username)
        {
            try
            {
                JObject UserData = Parser.ParseUserData(Username);
                return UserData["graphql"]["user"]["profile_pic_url"].Value<string>();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        /// <summary>
        /// Gets user's profile picture as HD
        /// </summary>
        /// <param name="Username">Username of the user to retrieve</param>
        /// <returns>HD profile picture</returns>
        public static string GetProfilePictureHD(string Username)
        {
            try
            {
                JObject UserData = Parser.ParseUserData(Username);
                return UserData["graphql"]["user"]["profile_pic_url_hd"].Value<string>();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        /// <summary>
        /// Checks if querying country is blocked by the user
        /// </summary>
        /// <param name="Username">Username of the user to retrieve</param>
        /// <returns>bool</returns>
        public static bool IsContryBlock(string Username)
        {
            try
            {
                JObject UserData = Parser.ParseUserData(Username);
                return UserData["graphql"]["user"]["country_block"].Value<bool>();
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Gets external url linked
        /// </summary>
        /// <param name="Username">Username of the user to retrieve</param>
        /// <returns>External url</returns>
        public static string GetExternalURL(string Username)
        {
            try
            {
                JObject UserData = Parser.ParseUserData(Username);
                return UserData["graphql"]["user"]["external_url"].Value<string>();
            }
            catch(Exception ex)
            {
                return ex.ToString();
            }
        }

        /// <summary>
        /// Gets user's followers count
        /// </summary>
        /// <param name="Username">Username of the user to retrieve</param>
        /// <returns>Followers</returns>
        public static int GetFollowers(string Username)
        {
            try
            {
                JObject UserData = Parser.ParseUserData(Username);
                return UserData["graphql"]["user"]["edge_followed_by"]["count"].Value<int>();
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Gets user's following count
        /// </summary>
        /// <param name="Username">Username of the user to retrieve</param>
        /// <returns>Followings</returns>
        public static int GetFollowings(string Username)
        {
            try
            {
                JObject UserData = Parser.ParseUserData(Username);
                return UserData["graphql"]["user"]["edge_follow"]["count"].Value<int>();
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Gets user's highlight count
        /// </summary>
        /// <param name="Username">Username of the user to retrieve</param>
        /// <returns>Highlights</returns>
        public static int GetHighlightCount(string Username)
        {
            try
            {
                JObject UserData = Parser.ParseUserData(Username);
                return UserData["graphql"]["user"]["highlight_reel_count"].Value<int>();
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Checks if user's account is private
        /// </summary>
        /// <param name="Username">Username of the user to retrieve</param>
        /// <returns>bool</returns>
        public static bool IsPrivate(string Username)
        {
            try
            {
                JObject UserData = Parser.ParseUserData(Username);
                return UserData["graphql"]["user"]["is_private"].Value<bool>();
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Checks if user's account is verified
        /// </summary>
        /// <param name="Username">Username of the user to retrieve</param>
        /// <returns>bool</returns>
        public static bool IsVerified(string Username)
        {
            try
            {
                JObject UserData = Parser.ParseUserData(Username);
                return UserData["graphql"]["user"]["is_verified"].Value<bool>();
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Checks if user's account is a business account
        /// </summary>
        /// <param name="Username">Username of the user to retrieve</param>
        /// <returns>bool</returns>
        public static bool IsBusinessAccount(string Username)
        {
            try
            {
                JObject UserData = Parser.ParseUserData(Username);
                return UserData["graphql"]["user"]["is_business_account"].Value<bool>();
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Checks if user has joined Instagram recently
        /// </summary>
        /// <param name="Username">Username of the user to retrieve</param>
        /// <returns>bool</returns>
        public static bool IsRecentlyJoined(string Username)
        {
            try
            {
                JObject UserData = Parser.ParseUserData(Username);
                return UserData["graphql"]["user"]["is_joined_recently"].Value<bool>();
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Checks if user has a Facebook page linked
        /// </summary>
        /// <param name="Username">Username of the user to retrieve</param>
        /// <returns>bool</returns>
        public static bool HasFacebookPage(string Username)
        {
            try
            {
                JObject UserData = Parser.ParseUserData(Username);
                return UserData["graphql"]["user"]["connected_fb_page"].Value<bool>();
            }
            catch
            {
                return false;
            }
        }
    }
}
