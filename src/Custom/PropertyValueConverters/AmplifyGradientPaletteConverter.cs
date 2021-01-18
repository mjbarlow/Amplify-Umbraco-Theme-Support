﻿using System;
using System.Collections.Generic;
using Amplify.Web.Custom.Models;
using Newtonsoft.Json;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Core.PropertyEditors;

namespace Amplify.Web.Custom.PropertyValueConverters
{
    class AmplifyGradientPaletteConverter : PropertyValueConverterBase
    {
        public override bool IsConverter(IPublishedPropertyType propertyType) =>
            (propertyType.EditorAlias).Equals(Internals.AmplifyGradientPalette);

        public override Type GetPropertyValueType(IPublishedPropertyType propertyType)
        => typeof(List<AmplifyGradient>);

        public override PropertyCacheLevel GetPropertyCacheLevel(IPublishedPropertyType propertyType) =>
        PropertyCacheLevel.Snapshot;

        public override bool? IsValue(object value, PropertyValueLevel level) => value?.ToString() != "[]";

        public override object ConvertSourceToIntermediate(IPublishedElement owner, IPublishedPropertyType propertyType,
            object source, bool preview) => source?.ToString();

        public override object ConvertIntermediateToObject(IPublishedElement owner, IPublishedPropertyType propertyType,
        PropertyCacheLevel referenceCacheLevel, object inter, bool preview)
        {
            return inter != null ? JsonConvert.DeserializeObject<List<AmplifyGradient>>(inter.ToString()) : new List<AmplifyGradient>();
        }
    }
}
