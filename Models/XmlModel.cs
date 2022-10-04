
// HINWEIS: Für den generierten Code ist möglicherweise mindestens .NET Framework 4.5 oder .NET Core/Standard 2.0 erforderlich.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class markers
{

    private object[] itemsField;

    private string[] textField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("marker", typeof(markersMarker))]
    [System.Xml.Serialization.XmlElementAttribute("x-marker", typeof(markersXmarker))]
    public object[] Items
    {
        get
        {
            return this.itemsField;
        }
        set
        {
            this.itemsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string[] Text
    {
        get
        {
            return this.textField;
        }
        set
        {
            this.textField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class markersMarker
{

    private object[] itemsField;

    private ItemsChoiceType[] itemsElementNameField;

    private string idField;

    private string catField;

    private string typeField;

    private string filterField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("beacon", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("bubble", typeof(byte))]
    [System.Xml.Serialization.XmlElementAttribute("details", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("icon", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("image", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("lat", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("link", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("lng", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("preview", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("summary", typeof(markersMarkerSummary))]
    [System.Xml.Serialization.XmlElementAttribute("title", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("url", typeof(string))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public object[] Items
    {
        get
        {
            return this.itemsField;
        }
        set
        {
            this.itemsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType[] ItemsElementName
    {
        get
        {
            return this.itemsElementNameField;
        }
        set
        {
            this.itemsElementNameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string cat
    {
        get
        {
            return this.catField;
        }
        set
        {
            this.catField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string filter
    {
        get
        {
            return this.filterField;
        }
        set
        {
            this.filterField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class markersMarkerSummary
{

    private object[] itemsField;

    private string[] textField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("a", typeof(markersMarkerSummaryA))]
    [System.Xml.Serialization.XmlElementAttribute("br", typeof(object))]
    public object[] Items
    {
        get
        {
            return this.itemsField;
        }
        set
        {
            this.itemsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string[] Text
    {
        get
        {
            return this.textField;
        }
        set
        {
            this.textField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class markersMarkerSummaryA
{

    private string hrefField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string href
    {
        get
        {
            return this.hrefField;
        }
        set
        {
            this.hrefField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
public enum ItemsChoiceType
{

    /// <remarks/>
    beacon,

    /// <remarks/>
    bubble,

    /// <remarks/>
    details,

    /// <remarks/>
    icon,

    /// <remarks/>
    image,

    /// <remarks/>
    lat,

    /// <remarks/>
    link,

    /// <remarks/>
    lng,

    /// <remarks/>
    preview,

    /// <remarks/>
    summary,

    /// <remarks/>
    title,

    /// <remarks/>
    url,
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class markersXmarker
{

    private object[] itemsField;

    private ItemsChoiceType1[] itemsElementNameField;

    private ushort idField;

    private string catField;

    private string typeField;

    private string filterField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("addr", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("beacon", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("icon", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("image", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("lat", typeof(decimal))]
    [System.Xml.Serialization.XmlElementAttribute("link", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("lng", typeof(decimal))]
    [System.Xml.Serialization.XmlElementAttribute("preview", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("summary", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("title", typeof(string))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public object[] Items
    {
        get
        {
            return this.itemsField;
        }
        set
        {
            this.itemsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType1[] ItemsElementName
    {
        get
        {
            return this.itemsElementNameField;
        }
        set
        {
            this.itemsElementNameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string cat
    {
        get
        {
            return this.catField;
        }
        set
        {
            this.catField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string filter
    {
        get
        {
            return this.filterField;
        }
        set
        {
            this.filterField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
public enum ItemsChoiceType1
{

    /// <remarks/>
    addr,

    /// <remarks/>
    beacon,

    /// <remarks/>
    icon,

    /// <remarks/>
    image,

    /// <remarks/>
    lat,

    /// <remarks/>
    link,

    /// <remarks/>
    lng,

    /// <remarks/>
    preview,

    /// <remarks/>
    summary,

    /// <remarks/>
    title,
}

