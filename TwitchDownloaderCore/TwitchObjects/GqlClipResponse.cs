﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TwitchDownloaderCore.TwitchObjects
{
    public class ClipNode
    {
        public string id { get; set; }
        public string slug { get; set; }
        public string title { get; set; }
        public DateTime createdAt { get; set; }
        public int durationSeconds { get; set; }
        public string thumbnailURL { get; set; }
        public int viewCount { get; set; }
    }

    public class Edge
    {
        public string cursor { get; set; }
        public ClipNode node { get; set; }
    }

    public class Clips
    {
        public List<Edge> edges { get; set; }
        public PageInfo pageInfo { get; set; }
    }

    public class ClipUser
    {
        public Clips clips { get; set; }
    }

    public class ClipData
    {
        public ClipUser user { get; set; }
    }

    public class GqlClipResponse
    {
        public ClipData data { get; set; }
        public Extensions extensions { get; set; }
    }


}
