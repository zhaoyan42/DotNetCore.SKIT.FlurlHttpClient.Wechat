﻿namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.Platform
{
    /// <summary>
    /// <para>表示 [POST] /nlp/sentiment/{TOKEN} 接口的请求。</para>
    /// </summary>
    public class NLPSentimentRequest : WechatOpenAIPlatformRequest, WechatOpenAIPlatformRequest.Serialization.IEncryptedUrlEncoded
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置输入文本。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("q")]
                [System.Text.Json.Serialization.JsonPropertyName("q")]
                public string QueryString { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置模式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mode")]
                [System.Text.Json.Serialization.JsonPropertyName("mode")]
                public string? Mode { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置用户 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("uid")]
        [System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置请求数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = new Types.Data();
    }
}
