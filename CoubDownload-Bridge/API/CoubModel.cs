﻿// Generated by https://quicktype.io

namespace QuickType
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class CoubModel
    {
        [JsonProperty("flag")]
        public bool? Flag { get; set; }

        [JsonProperty("abuses")]
        public object Abuses { get; set; }

        [JsonProperty("recoubs_by_users_channels")]
        public object[] RecoubsByUsersChannels { get; set; }

        [JsonProperty("favourite")]
        public bool? Favourite { get; set; }

        [JsonProperty("recoub")]
        public bool? Recoub { get; set; }

        [JsonProperty("like")]
        public bool? Like { get; set; }

        [JsonProperty("dislike")]
        public bool? Dislike { get; set; }

        [JsonProperty("in_my_best2015")]
        public bool? InMyBest2015 { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("permalink")]
        public string Permalink { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("visibility_type")]
        public string VisibilityType { get; set; }

        [JsonProperty("original_visibility_type")]
        public string OriginalVisibilityType { get; set; }

        [JsonProperty("channel_id")]
        public long ChannelId { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("is_done")]
        public bool? IsDone { get; set; }

        [JsonProperty("views_count")]
        public long ViewsCount { get; set; }

        [JsonProperty("cotd")]
        public object Cotd { get; set; }

        [JsonProperty("cotd_at")]
        public object CotdAt { get; set; }

        [JsonProperty("visible_on_explore_root")]
        public bool? VisibleOnExploreRoot { get; set; }

        [JsonProperty("visible_on_explore")]
        public bool? VisibleOnExplore { get; set; }

        [JsonProperty("featured")]
        public bool? Featured { get; set; }

        [JsonProperty("published")]
        public bool? Published { get; set; }

        [JsonProperty("published_at")]
        public DateTimeOffset PublishedAt { get; set; }

        [JsonProperty("reversed")]
        public bool? Reversed { get; set; }

        [JsonProperty("from_editor_v2")]
        public bool? FromEditorV2 { get; set; }

        [JsonProperty("is_editable")]
        public bool? IsEditable { get; set; }

        [JsonProperty("original_sound")]
        public bool? OriginalSound { get; set; }

        [JsonProperty("has_sound")]
        public bool? HasSound { get; set; }

        [JsonProperty("recoub_to")]
        public object RecoubTo { get; set; }

        [JsonProperty("file_versions")]
        public FileVersions FileVersions { get; set; }

        [JsonProperty("audio_versions")]
        public AudioVersions AudioVersions { get; set; }

        [JsonProperty("image_versions")]
        public Versions ImageVersions { get; set; }

        [JsonProperty("first_frame_versions")]
        public Versions FirstFrameVersions { get; set; }

        [JsonProperty("dimensions")]
        public Dimensions Dimensions { get; set; }

        [JsonProperty("site_w_h")]
        public long[] SiteWH { get; set; }

        [JsonProperty("page_w_h")]
        public long[] PageWH { get; set; }

        [JsonProperty("site_w_h_small")]
        public long[] SiteWHSmall { get; set; }

        [JsonProperty("age_restricted")]
        public bool? AgeRestricted { get; set; }

        [JsonProperty("age_restricted_by_admin")]
        public bool? AgeRestrictedByAdmin { get; set; }

        [JsonProperty("not_safe_for_work")]
        public bool? NotSafeForWork { get; set; }

        [JsonProperty("allow_reuse")]
        public bool? AllowReuse { get; set; }

        [JsonProperty("dont_crop")]
        public bool? DontCrop { get; set; }

        [JsonProperty("banned")]
        public bool? Banned { get; set; }

        [JsonProperty("global_safe")]
        public bool? GlobalSafe { get; set; }

        [JsonProperty("audio_file_url")]
        public Uri AudioFileUrl { get; set; }

        [JsonProperty("application")]
        public object Application { get; set; }

        [JsonProperty("channel")]
        public Channel Channel { get; set; }

        [JsonProperty("file")]
        public object File { get; set; }

        [JsonProperty("picture")]
        public Uri Picture { get; set; }

        [JsonProperty("timeline_picture")]
        public Uri TimelinePicture { get; set; }

        [JsonProperty("small_picture")]
        public Uri SmallPicture { get; set; }

        [JsonProperty("sharing_picture")]
        public object SharingPicture { get; set; }

        [JsonProperty("percent_done")]
        public long PercentDone { get; set; }

        [JsonProperty("tags")]
        public Tag[] Tags { get; set; }

        [JsonProperty("categories")]
        public Category[] Categories { get; set; }

        [JsonProperty("communities")]
        public Category[] Communities { get; set; }

        [JsonProperty("recoubs_count")]
        public long RecoubsCount { get; set; }

        [JsonProperty("remixes_count")]
        public long RemixesCount { get; set; }

        [JsonProperty("likes_count")]
        public long LikesCount { get; set; }

        [JsonProperty("dislikes_count")]
        public long DislikesCount { get; set; }

        [JsonProperty("raw_video_id")]
        public string RawVideoId { get; set; }

        [JsonProperty("uploaded_by_ios_app")]
        public bool? UploadedByIosApp { get; set; }

        [JsonProperty("uploaded_by_android_app")]
        public bool? UploadedByAndroidApp { get; set; }

        [JsonProperty("media_blocks")]
        public MediaBlocks MediaBlocks { get; set; }

        [JsonProperty("raw_video_thumbnail_url")]
        public string RawVideoThumbnailUrl { get; set; }

        [JsonProperty("raw_video_title")]
        public string RawVideoTitle { get; set; }

        [JsonProperty("video_block_banned")]
        public bool? VideoBlockBanned { get; set; }

        [JsonProperty("duration")]
        public long Duration { get; set; }

        [JsonProperty("promo_winner")]
        public bool? PromoWinner { get; set; }

        [JsonProperty("promo_winner_recoubers")]
        public object PromoWinnerRecoubers { get; set; }

        [JsonProperty("editorial_info")]
        public EditorialInfo EditorialInfo { get; set; }

        [JsonProperty("promo_hint")]
        public object PromoHint { get; set; }

        [JsonProperty("beeline_best_2014")]
        public object BeelineBest2014 { get; set; }

        [JsonProperty("from_web_editor")]
        public bool? FromWebEditor { get; set; }

        [JsonProperty("normalize_sound")]
        public bool? NormalizeSound { get; set; }

        [JsonProperty("best2015_addable")]
        public bool? Best2015Addable { get; set; }

        [JsonProperty("ahmad_promo")]
        public object AhmadPromo { get; set; }

        [JsonProperty("promo_data")]
        public object PromoData { get; set; }

        [JsonProperty("audio_copyright_claim")]
        public object AudioCopyrightClaim { get; set; }

        [JsonProperty("ads_disabled")]
        public bool? AdsDisabled { get; set; }

        [JsonProperty("is_safe_for_ads")]
        public bool? IsSafeForAds { get; set; }
    }

    public class AudioVersions
    {
        [JsonProperty("template")]
        public Uri Template { get; set; }

        [JsonProperty("versions")]
        public string[] Versions { get; set; }

        [JsonProperty("chunks")]
        public Chunks Chunks { get; set; }
    }
    public class ExternalDownload
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("service_name")]
        public string ServiceName { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("has_embed")]
        public bool HasEmbed { get; set; }
    }
    public class Chunks
    {
        [JsonProperty("template")]
        public string Template { get; set; }

        [JsonProperty("versions")]
        public string[] Versions { get; set; }

        [JsonProperty("chunks")]
        public long[] ChunksChunks { get; set; }
    }

    public class Category
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("permalink")]
        public string Permalink { get; set; }

        [JsonProperty("subscriptions_count")]
        public long SubscriptionsCount { get; set; }

        [JsonProperty("big_image_url")]
        public Uri BigImageUrl { get; set; }

        [JsonProperty("small_image_url")]
        public Uri SmallImageUrl { get; set; }

        [JsonProperty("med_image_url")]
        public Uri MedImageUrl { get; set; }

        [JsonProperty("visible", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Visible { get; set; }

        [JsonProperty("i_subscribed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ISubscribed { get; set; }

        [JsonProperty("community_notifications_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CommunityNotificationsEnabled { get; set; }
    }

    public class Channel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("permalink")]
        public string Permalink { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("i_follow_him")]
        public bool? IFollowHim { get; set; }

        [JsonProperty("follows_by_users_channels")]
        public object[] FollowsByUsersChannels { get; set; }

        [JsonProperty("followers_count")]
        public long FollowersCount { get; set; }

        [JsonProperty("following_count")]
        public long FollowingCount { get; set; }

        [JsonProperty("avatar_versions")]
        public Versions AvatarVersions { get; set; }

        [JsonProperty("background_image")]
        public Uri BackgroundImage { get; set; }

        [JsonProperty("coubs_count")]
        public long CoubsCount { get; set; }

        [JsonProperty("recoubs_count")]
        public long RecoubsCount { get; set; }
    }

    public class Versions
    {
        [JsonProperty("template")]
        public string Template { get; set; }

        [JsonProperty("versions")]
        public string[] VersionsVersions { get; set; }
    }

    public class Dimensions
    {
        [JsonProperty("big")]
        public long[] Big { get; set; }

        [JsonProperty("med")]
        public long[] Med { get; set; }
    }

    public class EditorialInfo
    {
    }

    public class FileVersions
    {
        [JsonProperty("html5")]
        public Html5 Html5 { get; set; }

        [JsonProperty("mobile")]
        public Mobile Mobile { get; set; }
    }

    public class Html5
    {
        [JsonProperty("video")]
        public Audio Video { get; set; }

        [JsonProperty("audio")]
        public Audio Audio { get; set; }
    }

    public class Audio
    {
        [JsonProperty("high")]
        public High High { get; set; }

        [JsonProperty("med")]
        public High Med { get; set; }
    }

    public class High
    {
        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }
    }

    public class Mobile
    {
        [JsonProperty("gifv")]
        public string Gifv { get; set; }

        [JsonProperty("audio")]
        public Uri[] Audio { get; set; }
    }

    public class MediaBlocks
    {
        [JsonProperty("uploaded_raw_videos")]
        public object[] UploadedRawVideos { get; set; }

        [JsonProperty("external_raw_videos")]
        public object[] ExternalRawVideos { get; set; }

        [JsonProperty("remixed_from_coubs")]
        public RemixedFromCoub[] RemixedFromCoubs { get; set; }
    }

    public class RemixedFromCoub
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("image")]
        public Uri Image { get; set; }

        [JsonProperty("image_retina")]
        public Uri ImageRetina { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("duration")]
        public object Duration { get; set; }

        [JsonProperty("coub_channel_title")]
        public string CoubChannelTitle { get; set; }

        [JsonProperty("coub_channel_permalink")]
        public string CoubChannelPermalink { get; set; }

        [JsonProperty("coub_views_count")]
        public long CoubViewsCount { get; set; }

        [JsonProperty("coub_permalink")]
        public string CoubPermalink { get; set; }
    }

    public class Meta
    {
        [JsonProperty("duration")]
        public string Duration { get; set; }
    }

    public class Tag
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class ObjectOrNullConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {   // name used in a previous answer
            return (objectType == typeof(bool) || objectType == typeof(object));
        }

        public override object ReadJson(JsonReader reader, Type objectType,
                                    object existingValue, JsonSerializer serializer)
        {
            var token = JToken.Load(reader);
            return (objectType == typeof(bool) || objectType == typeof(int) || objectType == typeof(string)) ? null : token.ToObject<object>();
        }

        public override void WriteJson(JsonWriter writer, object value,
                        JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}