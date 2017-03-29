using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slk.Common
{
    public class MimeTypes
    {
        ///<summary>Used to denote the encoding necessary for files containing JavaScript source code. The alternative MIME type for this file type is text/javascript.</summary>
        public const string ApplicationXJavascript = "application/x-javascript";

        ///<summary>24bit Linear PCM audio at 8-48kHz, 1-N channels; Defined in RFC 3190</summary>
        public const string AudioL24 = "audio/L24";

        ///<summary>Adobe Flash files for example with the extension .swf</summary>
        public const string ApplicationXShockwaveFlash = "application/x-shockwave-flash";

        ///<summary>Arbitrary binary data.[5] Generally speaking this type identifies files that are not associated with a specific application. Contrary to past assumptions by software packages such as Apache this is not a type that should be applied to unknown files. In such a case, a server or application should not indicate a content type, as it may be incorrect, but rather, should omit the type in order to allow the recipient to guess the type.[6]</summary>
        public const string ApplicationOctetStream = "application/octet-stream";

        ///<summary>Atom feeds</summary>
        public const string ApplicationAtomXml = "application/atom+xml";

        ///<summary>Cascading Style Sheets; Defined in RFC 2318</summary>
        public const string TextCss = "text/css";

        ///<summary>commands; subtype resident in Gecko browsers like Firefox 3.5</summary>
        public const string TextCmd = "text/cmd";

        ///<summary>Comma-separated values; Defined in RFC 4180</summary>
        public const string TextCsv = "text/csv";

        ///<summary>deb (file format), a software package format used by the Debian project</summary>
        public const string ApplicationXDeb = "application/x-deb";

        ///<summary>Defined in RFC 1847</summary>
        public const string MultipartEncrypted = "multipart/encrypted";

        ///<summary>Defined in RFC 1847</summary>
        public const string MultipartSigned = "multipart/signed";

        ///<summary>Defined in RFC 2616</summary>
        public const string MessageHttp = "message/http";

        ///<summary>Defined in RFC 4735</summary>
        public const string ModelExample = "model/example";

        ///<summary>device-independent document in DVI format</summary>
        public const string ApplicationXDvi = "application/x-dvi";

        ///<summary>DTD files; Defined by RFC 3023</summary>
        public const string ApplicationXmlDtd = "application/xml-dtd";

        ///<summary>ECMAScript/JavaScript; Defined in RFC 4329 (equivalent to application/ecmascript but with looser processing rules) It is not accepted in IE 8 or earlier - text/javascript is accepted but it is defined as obsolete in RFC 4329. The "type" attribute of the <script> tag in HTML5 is optional and in practice omitting the media type of JavaScript programs is the most interoperable solution since all browsers have always assumed the correct default even before HTML5.</summary>
        public const string ApplicationJavascript = "application/javascript";

        ///<summary>ECMAScript/JavaScript; Defined in RFC 4329 (equivalent to application/javascript but with stricter processing rules)</summary>
        public const string ApplicationEcmascript = "application/ecmascript";

        ///<summary>EDI EDIFACT data; Defined in RFC 1767</summary>
        public const string ApplicationEdifact = "application/EDIFACT";

        ///<summary>EDI X12 data; Defined in RFC 1767</summary>
        public const string ApplicationEdiX12 = "application/EDI-X12";

        ///<summary>Email; Defined in RFC 2045 and RFC 2046</summary>
        public const string MessagePartial = "message/partial";

        ///<summary>Email; EML files, MIME files, MHT files, MHTML files; Defined in RFC 2045 and RFC 2046</summary>
        public const string MessageRfc822 = "message/rfc822";

        ///<summary>Extensible Markup Language; Defined in RFC 3023</summary>
        public const string TextXml = "text/xml";

        ///<summary>Extensible Markup Language; Defined in RFC 3023</summary>
        public const string ApplicationXml = "application/xml";

        ///<summary>Flash video (FLV files)</summary>
        public const string VideoXFlv = "video/x-flv";

        ///<summary>GIF image; Defined in RFC 2045 and RFC 2046</summary>
        public const string ImageGif = "image/gif";

        ///<summary>GoogleWebToolkit data</summary>
        public const string TextXGwtRpc = "text/x-gwt-rpc";

        ///<summary>Gzip</summary>
        public const string ApplicationXGzip = "application/x-gzip";

        ///<summary>HTML; Defined in RFC 2854</summary>
        public const string TextHtml = "text/html";

        ///<summary>ICO image; Registered[9]</summary>
        public const string ImageVndMicrosoftIcon = "image/vnd.microsoft.icon";

        ///<summary>IGS files, IGES files; Defined in RFC 2077</summary>
        public const string ModelIges = "model/iges";

        ///<summary>IMDN Instant Message Disposition Notification; Defined in RFC 5438</summary>
        public const string MessageImdnXml = "message/imdn+xml";

        ///<summary>JavaScript Object Notation JSON; Defined in RFC 4627</summary>
        public const string ApplicationJson = "application/json";

        ///<summary>JavaScript Object Notation (JSON) Patch; Defined in RFC 6902</summary>
        public const string ApplicationJsonPatch = "application/json-patch+json";

        ///<summary>JavaScript - Defined in and obsoleted by RFC 4329 in order to discourage its usage in favor of application/javascript. However,text/javascript is allowed in HTML 4 and 5 and, unlike application/javascript, has cross-browser support. The "type" attribute of the <script> tag in HTML5 is optional and there is no need to use it at all since all browsers have always assumed the correct default (even in HTML 4 where it was required by the specification).</summary>
        [Obsolete]
        public const string TextJavascript = "text/javascript";

        ///<summary>JPEG JFIF image; Associated with Internet Explorer; Listed in ms775147(v=vs.85) - Progressive JPEG, initiated before global browser support for progressive JPEGs (Microsoft and Firefox).</summary>
        public const string ImagePjpeg = "image/pjpeg";

        ///<summary>JPEG JFIF image; Defined in RFC 2045 and RFC 2046</summary>
        public const string ImageJpeg = "image/jpeg";

        ///<summary>jQuery template data</summary>
        public const string TextXJqueryTmpl = "text/x-jquery-tmpl";

        ///<summary>KML files (e.g. for Google Earth)</summary>
        public const string ApplicationVndGoogleEarthKmlXml = "application/vnd.google-earth.kml+xml";

        ///<summary>LaTeX files</summary>
        public const string ApplicationXLatex = "application/x-latex";

        ///<summary>Matroska open media format</summary>
        public const string VideoXMatroska = "video/x-matroska";

        ///<summary>Microsoft Excel 2007 files</summary>
        public const string ApplicationVndOpenxmlformatsOfficedocumentSpreadsheetmlSheet = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";

        ///<summary>Microsoft Excel files</summary>
        public const string ApplicationVndMsExcel = "application/vnd.ms-excel";

        ///<summary>Microsoft Powerpoint 2007 files</summary>
        public const string ApplicationVndOpenxmlformatsOfficedocumentPresentationmlPresentation = "application/vnd.openxmlformats-officedocument.presentationml.presentation";

        ///<summary>Microsoft Powerpoint files</summary>
        public const string ApplicationVndMsPowerpoint = "application/vnd.ms-powerpoint";

        ///<summary>Microsoft Word 2007 files</summary>
        public const string ApplicationVndOpenxmlformatsOfficedocumentWordprocessingmlDocument = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";

        ///<summary>Microsoft Word files[15]</summary>
        public const string ApplicationMsword = "application/msword";

        ///<summary>MIME Email; Defined in RFC 2045 and RFC 2046</summary>
        public const string MultipartAlternative = "multipart/alternative";

        ///<summary>MIME Email; Defined in RFC 2045 and RFC 2046</summary>
        public const string MultipartMixed = "multipart/mixed";

        ///<summary>MIME Email; Defined in RFC 2387 and used by MHTML (HTML mail)</summary>
        public const string MultipartRelated = "multipart/related";

        ///<summary>MIME Webform; Defined in RFC 2388</summary>
        public const string MultipartFormData = "multipart/form-data";

        ///<summary>Mozilla XUL files</summary>
        public const string ApplicationVndMozillaXulXml = "application/vnd.mozilla.xul+xml";

        ///<summary>MP3 or other MPEG audio; Defined in RFC 3003</summary>
        public const string AudioMpeg = "audio/mpeg";

        ///<summary>MP4 audio</summary>
        public const string AudioMp4 = "audio/mp4";

        ///<summary>MP4 video; Defined in RFC 4337</summary>
        public const string VideoMp4 = "video/mp4";

        ///<summary>MPEG-1 video with multiplexed audio; Defined in RFC 2045 and RFC 2046</summary>
        public const string VideoMpeg = "video/mpeg";

        ///<summary>MSH files, MESH files; Defined in RFC 2077, SILO files</summary>
        public const string ModelMesh = "model/mesh";

        ///<summary>mulaw audio at 8 kHz, 1 channel; Defined in RFC 2046</summary>
        public const string AudioBasic = "audio/basic";

        ///<summary>Ogg Theora or other video (with audio); Defined in RFC 5334</summary>
        public const string VideoOgg = "video/ogg";

        ///<summary>Ogg Vorbis, Speex, Flac and other audio; Defined in RFC 5334</summary>
        public const string AudioOgg = "audio/ogg";

        ///<summary>Ogg, a multimedia bitstream container format; Defined in RFC 5334</summary>
        public const string ApplicationOgg = "application/ogg";

        ///<summary>OP</summary>
        public const string ApplicationXopXml = "application/xop+xml";

        ///<summary>OpenDocument Graphics; Registered[14]</summary>
        public const string ApplicationVndOasisOpendocumentGraphics = "application/vnd.oasis.opendocument.graphics";

        ///<summary>OpenDocument Presentation; Registered[13]</summary>
        public const string ApplicationVndOasisOpendocumentPresentation = "application/vnd.oasis.opendocument.presentation";

        ///<summary>OpenDocument Spreadsheet; Registered[12]</summary>
        public const string ApplicationVndOasisOpendocumentSpreadsheet = "application/vnd.oasis.opendocument.spreadsheet";

        ///<summary>OpenDocument Text; Registered[11]</summary>
        public const string ApplicationVndOasisOpendocumentText = "application/vnd.oasis.opendocument.text";

        ///<summary>p12 files</summary>
        public const string ApplicationXPkcs12 = "application/x-pkcs12";

        ///<summary>p7b and spc files</summary>
        public const string ApplicationXPkcs7Certificates = "application/x-pkcs7-certificates";

        ///<summary>p7c files</summary>
        public const string ApplicationXPkcs7Mime = "application/x-pkcs7-mime";

        ///<summary>p7r files</summary>
        public const string ApplicationXPkcs7Certreqresp = "application/x-pkcs7-certreqresp";

        ///<summary>p7s files</summary>
        public const string ApplicationXPkcs7Signature = "application/x-pkcs7-signature";

        ///<summary>Portable Document Format, PDF has been in use for document exchange on the Internet since 1993; Defined in RFC 3778</summary>
        public const string ApplicationPdf = "application/pdf";

        ///<summary>Portable Network Graphics; Registered,[8] Defined in RFC 2083</summary>
        public const string ImagePng = "image/png";

        ///<summary>PostScript; Defined in RFC 2046</summary>
        public const string ApplicationPostscript = "application/postscript";

        ///<summary>QuickTime video; Registered[10]</summary>
        public const string VideoQuicktime = "video/quicktime";

        ///<summary>RAR archive files</summary>
        public const string ApplicationXRarCompressed = "application/x-rar-compressed";

        ///<summary>RealAudio; Documented in RealPlayer Customer Support Answer 2559</summary>
        public const string AudioVndRnRealaudio = "audio/vnd.rn-realaudio";

        ///<summary>Resource Description Framework; Defined by RFC 3870</summary>
        public const string ApplicationRdfXml = "application/rdf+xml";

        ///<summary>RSS feeds</summary>
        public const string ApplicationRssXml = "application/rss+xml";

        ///<summary>SOAP; Defined by RFC 3902</summary>
        public const string ApplicationSoapXml = "application/soap+xml";

        ///<summary>StuffIt archive files</summary>
        public const string ApplicationXStuffit = "application/x-stuffit";

        ///<summary>SVG vector image; Defined in SVG Tiny 1.2 Specification Appendix M</summary>
        public const string ImageSvgXml = "image/svg+xml";

        ///<summary>Tag Image File Format (only for Baseline TIFF); Defined in RFC 3302</summary>
        public const string ImageTiff = "image/tiff";

        ///<summary>Tarball files</summary>
        public const string ApplicationXTar = "application/x-tar";

        ///<summary>Textual data; Defined in RFC 2046 and RFC 3676</summary>
        public const string TextPlain = "text/plain";

        ///<summary>TrueType Font No registered MIME type, but this is the most commonly used</summary>
        public const string ApplicationXFontTtf = "application/x-font-ttf";

        ///<summary>vCard (contact information); Defined in RFC 6350</summary>
        public const string TextVcard = "text/vcard";

        ///<summary>Vorbis encoded audio; Defined in RFC 5215</summary>
        public const string AudioVorbis = "audio/vorbis";

        ///<summary>WAV audio; Defined in RFC 2361</summary>
        public const string AudioVndWave = "audio/vnd.wave";

        ///<summary>Web Open Font Format; (candidate recommendation; use application/x-font-woff until standard is official)</summary>
        public const string ApplicationFontWoff = "application/font-woff";

        ///<summary>WebM Matroska-based open media format</summary>
        public const string VideoWebm = "video/webm";

        ///<summary>WebM open media format</summary>
        public const string AudioWebm = "audio/webm";

        ///<summary>Windows Media Audio Redirector; Documented in Microsoft help page</summary>
        public const string AudioXMsWax = "audio/x-ms-wax";

        ///<summary>Windows Media Audio; Documented in Microsoft KB 288102</summary>
        public const string AudioXMsWma = "audio/x-ms-wma";

        ///<summary>Windows Media Video; Documented in Microsoft KB 288102</summary>
        public const string VideoXMsWmv = "video/x-ms-wmv";

        ///<summary>WRL files, VRML files; Defined in RFC 2077</summary>
        public const string ModelVrml = "model/vrml";

        ///<summary>X3D ISO standard for representing 3D computer graphics, X3D XML files</summary>
        public const string ModelX3DXml = "model/x3d+xml";

        ///<summary>X3D ISO standard for representing 3D computer graphics, X3DB binary files</summary>
        public const string ModelX3DBinary = "model/x3d+binary";

        ///<summary>X3D ISO standard for representing 3D computer graphics, X3DV VRML files</summary>
        public const string ModelX3DVrml = "model/x3d+vrml";

        ///<summary>XHTML; Defined by RFC 3236</summary>
        public const string ApplicationXhtmlXml = "application/xhtml+xml";

        ///<summary>ZIP archive files; Registered[7]</summary>
        public const string ApplicationZip = "application/zip";


        private static IDictionary<string, string> _mappings = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase) {

        #region Big freaking list of mime types
        // combination of values from Windows 7 Registry and 
        // from C:\Windows\System32\inetsrv\config\applicationHost.config
        // some added, including .7z and .dat
        {".323", "text/h323"},
        {".3g2", "video/3gpp2"},
        {".3gp", "video/3gpp"},
        {".3gp2", "video/3gpp2"},
        {".3gpp", "video/3gpp"},
        {".7z", "application/x-7z-compressed"},
        {".aa", "audio/audible"},
        {".AAC", "audio/aac"},
        {".aaf", "application/octet-stream"},
        {".aax", "audio/vnd.audible.aax"},
        {".ac3", "audio/ac3"},
        {".aca", "application/octet-stream"},
        {".accda", "application/msaccess.addin"},
        {".accdb", "application/msaccess"},
        {".accdc", "application/msaccess.cab"},
        {".accde", "application/msaccess"},
        {".accdr", "application/msaccess.runtime"},
        {".accdt", "application/msaccess"},
        {".accdw", "application/msaccess.webapplication"},
        {".accft", "application/msaccess.ftemplate"},
        {".acx", "application/internet-property-stream"},
        {".AddIn", "text/xml"},
        {".ade", "application/msaccess"},
        {".adobebridge", "application/x-bridge-url"},
        {".adp", "application/msaccess"},
        {".ADT", "audio/vnd.dlna.adts"},
        {".ADTS", "audio/aac"},
        {".afm", "application/octet-stream"},
        {".ai", "application/postscript"},
        {".aif", "audio/x-aiff"},
        {".aifc", "audio/aiff"},
        {".aiff", "audio/aiff"},
        {".air", "application/vnd.adobe.air-application-installer-package+zip"},
        {".amc", "application/x-mpeg"},
        {".application", "application/x-ms-application"},
        {".art", "image/x-jg"},
        {".asa", "application/xml"},
        {".asax", "application/xml"},
        {".ascx", "application/xml"},
        {".asd", "application/octet-stream"},
        {".asf", "video/x-ms-asf"},
        {".ashx", "application/xml"},
        {".asi", "application/octet-stream"},
        {".asm", "text/plain"},
        {".asmx", "application/xml"},
        {".aspx", "application/xml"},
        {".asr", "video/x-ms-asf"},
        {".asx", "video/x-ms-asf"},
        {".atom", "application/atom+xml"},
        {".au", "audio/basic"},
        {".avi", "video/x-msvideo"},
        {".axs", "application/olescript"},
        {".bas", "text/plain"},
        {".bcpio", "application/x-bcpio"},
        {".bin", "application/octet-stream"},
        {".bmp", "image/bmp"},
        {".c", "text/plain"},
        {".cab", "application/octet-stream"},
        {".caf", "audio/x-caf"},
        {".calx", "application/vnd.ms-office.calx"},
        {".cat", "application/vnd.ms-pki.seccat"},
        {".cc", "text/plain"},
        {".cd", "text/plain"},
        {".cdda", "audio/aiff"},
        {".cdf", "application/x-cdf"},
        {".cer", "application/x-x509-ca-cert"},
        {".chm", "application/octet-stream"},
        {".class", "application/x-java-applet"},
        {".clp", "application/x-msclip"},
        {".cmx", "image/x-cmx"},
        {".cnf", "text/plain"},
        {".cod", "image/cis-cod"},
        {".config", "application/xml"},
        {".contact", "text/x-ms-contact"},
        {".coverage", "application/xml"},
        {".cpio", "application/x-cpio"},
        {".cpp", "text/plain"},
        {".crd", "application/x-mscardfile"},
        {".crl", "application/pkix-crl"},
        {".crt", "application/x-x509-ca-cert"},
        {".cs", "text/plain"},
        {".csdproj", "text/plain"},
        {".csh", "application/x-csh"},
        {".csproj", "text/plain"},
        {".css", "text/css"},
        {".csv", "text/csv"},
        {".cur", "application/octet-stream"},
        {".cxx", "text/plain"},
        {".dat", "application/octet-stream"},
        {".datasource", "application/xml"},
        {".dbproj", "text/plain"},
        {".dcr", "application/x-director"},
        {".def", "text/plain"},
        {".deploy", "application/octet-stream"},
        {".der", "application/x-x509-ca-cert"},
        {".dgml", "application/xml"},
        {".dib", "image/bmp"},
        {".dif", "video/x-dv"},
        {".dir", "application/x-director"},
        {".disco", "text/xml"},
        {".dll", "application/x-msdownload"},
        {".dll.config", "text/xml"},
        {".dlm", "text/dlm"},
        {".doc", "application/msword"},
        {".docm", "application/vnd.ms-word.document.macroEnabled.12"},
        {".docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document"},
        {".dot", "application/msword"},
        {".dotm", "application/vnd.ms-word.template.macroEnabled.12"},
        {".dotx", "application/vnd.openxmlformats-officedocument.wordprocessingml.template"},
        {".dsp", "application/octet-stream"},
        {".dsw", "text/plain"},
        {".dtd", "text/xml"},
        {".dtsConfig", "text/xml"},
        {".dv", "video/x-dv"},
        {".dvi", "application/x-dvi"},
        {".dwf", "drawing/x-dwf"},
        {".dwp", "application/octet-stream"},
        {".dxr", "application/x-director"},
        {".eml", "message/rfc822"},
        {".emz", "application/octet-stream"},
        {".eot", "application/octet-stream"},
        {".eps", "application/postscript"},
        {".etl", "application/etl"},
        {".etx", "text/x-setext"},
        {".evy", "application/envoy"},
        {".exe", "application/octet-stream"},
        {".exe.config", "text/xml"},
        {".fdf", "application/vnd.fdf"},
        {".fif", "application/fractals"},
        {".filters", "Application/xml"},
        {".fla", "application/octet-stream"},
        {".flr", "x-world/x-vrml"},
        {".flv", "video/x-flv"},
        {".fsscript", "application/fsharp-script"},
        {".fsx", "application/fsharp-script"},
        {".generictest", "application/xml"},
        {".gif", "image/gif"},
        {".group", "text/x-ms-group"},
        {".gsm", "audio/x-gsm"},
        {".gtar", "application/x-gtar"},
        {".gz", "application/x-gzip"},
        {".h", "text/plain"},
        {".hdf", "application/x-hdf"},
        {".hdml", "text/x-hdml"},
        {".hhc", "application/x-oleobject"},
        {".hhk", "application/octet-stream"},
        {".hhp", "application/octet-stream"},
        {".hlp", "application/winhlp"},
        {".hpp", "text/plain"},
        {".hqx", "application/mac-binhex40"},
        {".hta", "application/hta"},
        {".htc", "text/x-component"},
        {".htm", "text/html"},
        {".html", "text/html"},
        {".htt", "text/webviewhtml"},
        {".hxa", "application/xml"},
        {".hxc", "application/xml"},
        {".hxd", "application/octet-stream"},
        {".hxe", "application/xml"},
        {".hxf", "application/xml"},
        {".hxh", "application/octet-stream"},
        {".hxi", "application/octet-stream"},
        {".hxk", "application/xml"},
        {".hxq", "application/octet-stream"},
        {".hxr", "application/octet-stream"},
        {".hxs", "application/octet-stream"},
        {".hxt", "text/html"},
        {".hxv", "application/xml"},
        {".hxw", "application/octet-stream"},
        {".hxx", "text/plain"},
        {".i", "text/plain"},
        {".ico", "image/x-icon"},
        {".ics", "application/octet-stream"},
        {".idl", "text/plain"},
        {".ief", "image/ief"},
        {".iii", "application/x-iphone"},
        {".inc", "text/plain"},
        {".inf", "application/octet-stream"},
        {".inl", "text/plain"},
        {".ins", "application/x-internet-signup"},
        {".ipa", "application/x-itunes-ipa"},
        {".ipg", "application/x-itunes-ipg"},
        {".ipproj", "text/plain"},
        {".ipsw", "application/x-itunes-ipsw"},
        {".iqy", "text/x-ms-iqy"},
        {".isp", "application/x-internet-signup"},
        {".ite", "application/x-itunes-ite"},
        {".itlp", "application/x-itunes-itlp"},
        {".itms", "application/x-itunes-itms"},
        {".itpc", "application/x-itunes-itpc"},
        {".IVF", "video/x-ivf"},
        {".jar", "application/java-archive"},
        {".java", "application/octet-stream"},
        {".jck", "application/liquidmotion"},
        {".jcz", "application/liquidmotion"},
        {".jfif", "image/pjpeg"},
        {".jnlp", "application/x-java-jnlp-file"},
        {".jpb", "application/octet-stream"},
        {".jpe", "image/jpeg"},
        {".jpeg", "image/jpeg"},
        {".jpg", "image/jpeg"},
        {".js", "application/x-javascript"},
        {".json", "application/json"},
        {".jsx", "text/jscript"},
        {".jsxbin", "text/plain"},
        {".latex", "application/x-latex"},
        {".library-ms", "application/windows-library+xml"},
        {".lit", "application/x-ms-reader"},
        {".loadtest", "application/xml"},
        {".lpk", "application/octet-stream"},
        {".lsf", "video/x-la-asf"},
        {".lst", "text/plain"},
        {".lsx", "video/x-la-asf"},
        {".lzh", "application/octet-stream"},
        {".m13", "application/x-msmediaview"},
        {".m14", "application/x-msmediaview"},
        {".m1v", "video/mpeg"},
        {".m2t", "video/vnd.dlna.mpeg-tts"},
        {".m2ts", "video/vnd.dlna.mpeg-tts"},
        {".m2v", "video/mpeg"},
        {".m3u", "audio/x-mpegurl"},
        {".m3u8", "audio/x-mpegurl"},
        {".m4a", "audio/m4a"},
        {".m4b", "audio/m4b"},
        {".m4p", "audio/m4p"},
        {".m4r", "audio/x-m4r"},
        {".m4v", "video/x-m4v"},
        {".mac", "image/x-macpaint"},
        {".mak", "text/plain"},
        {".man", "application/x-troff-man"},
        {".manifest", "application/x-ms-manifest"},
        {".map", "text/plain"},
        {".master", "application/xml"},
        {".mda", "application/msaccess"},
        {".mdb", "application/x-msaccess"},
        {".mde", "application/msaccess"},
        {".mdp", "application/octet-stream"},
        {".me", "application/x-troff-me"},
        {".mfp", "application/x-shockwave-flash"},
        {".mht", "message/rfc822"},
        {".mhtml", "message/rfc822"},
        {".mid", "audio/mid"},
        {".midi", "audio/mid"},
        {".mix", "application/octet-stream"},
        {".mk", "text/plain"},
        {".mmf", "application/x-smaf"},
        {".mno", "text/xml"},
        {".mny", "application/x-msmoney"},
        {".mod", "video/mpeg"},
        {".mov", "video/quicktime"},
        {".movie", "video/x-sgi-movie"},
        {".mp2", "video/mpeg"},
        {".mp2v", "video/mpeg"},
        {".mp3", "audio/mpeg"},
        {".mp4", "video/mp4"},
        {".mp4v", "video/mp4"},
        {".mpa", "video/mpeg"},
        {".mpe", "video/mpeg"},
        {".mpeg", "video/mpeg"},
        {".mpf", "application/vnd.ms-mediapackage"},
        {".mpg", "video/mpeg"},
        {".mpp", "application/vnd.ms-project"},
        {".mpv2", "video/mpeg"},
        {".mqv", "video/quicktime"},
        {".ms", "application/x-troff-ms"},
        {".msi", "application/octet-stream"},
        {".mso", "application/octet-stream"},
        {".mts", "video/vnd.dlna.mpeg-tts"},
        {".mtx", "application/xml"},
        {".mvb", "application/x-msmediaview"},
        {".mvc", "application/x-miva-compiled"},
        {".mxp", "application/x-mmxp"},
        {".nc", "application/x-netcdf"},
        {".nsc", "video/x-ms-asf"},
        {".nws", "message/rfc822"},
        {".ocx", "application/octet-stream"},
        {".oda", "application/oda"},
        {".odc", "text/x-ms-odc"},
        {".odh", "text/plain"},
        {".odl", "text/plain"},
        {".odp", "application/vnd.oasis.opendocument.presentation"},
        {".ods", "application/oleobject"},
        {".odt", "application/vnd.oasis.opendocument.text"},
        {".one", "application/onenote"},
        {".onea", "application/onenote"},
        {".onepkg", "application/onenote"},
        {".onetmp", "application/onenote"},
        {".onetoc", "application/onenote"},
        {".onetoc2", "application/onenote"},
        {".orderedtest", "application/xml"},
        {".osdx", "application/opensearchdescription+xml"},
        {".p10", "application/pkcs10"},
        {".p12", "application/x-pkcs12"},
        {".p7b", "application/x-pkcs7-certificates"},
        {".p7c", "application/pkcs7-mime"},
        {".p7m", "application/pkcs7-mime"},
        {".p7r", "application/x-pkcs7-certreqresp"},
        {".p7s", "application/pkcs7-signature"},
        {".pbm", "image/x-portable-bitmap"},
        {".pcast", "application/x-podcast"},
        {".pct", "image/pict"},
        {".pcx", "application/octet-stream"},
        {".pcz", "application/octet-stream"},
        {".pdf", "application/pdf"},
        {".pfb", "application/octet-stream"},
        {".pfm", "application/octet-stream"},
        {".pfx", "application/x-pkcs12"},
        {".pgm", "image/x-portable-graymap"},
        {".pic", "image/pict"},
        {".pict", "image/pict"},
        {".pkgdef", "text/plain"},
        {".pkgundef", "text/plain"},
        {".pko", "application/vnd.ms-pki.pko"},
        {".pls", "audio/scpls"},
        {".pma", "application/x-perfmon"},
        {".pmc", "application/x-perfmon"},
        {".pml", "application/x-perfmon"},
        {".pmr", "application/x-perfmon"},
        {".pmw", "application/x-perfmon"},
        {".png", "image/png"},
        {".pnm", "image/x-portable-anymap"},
        {".pnt", "image/x-macpaint"},
        {".pntg", "image/x-macpaint"},
        {".pnz", "image/png"},
        {".pot", "application/vnd.ms-powerpoint"},
        {".potm", "application/vnd.ms-powerpoint.template.macroEnabled.12"},
        {".potx", "application/vnd.openxmlformats-officedocument.presentationml.template"},
        {".ppa", "application/vnd.ms-powerpoint"},
        {".ppam", "application/vnd.ms-powerpoint.addin.macroEnabled.12"},
        {".ppm", "image/x-portable-pixmap"},
        {".pps", "application/vnd.ms-powerpoint"},
        {".ppsm", "application/vnd.ms-powerpoint.slideshow.macroEnabled.12"},
        {".ppsx", "application/vnd.openxmlformats-officedocument.presentationml.slideshow"},
        {".ppt", "application/vnd.ms-powerpoint"},
        {".pptm", "application/vnd.ms-powerpoint.presentation.macroEnabled.12"},
        {".pptx", "application/vnd.openxmlformats-officedocument.presentationml.presentation"},
        {".prf", "application/pics-rules"},
        {".prm", "application/octet-stream"},
        {".prx", "application/octet-stream"},
        {".ps", "application/postscript"},
        {".psc1", "application/PowerShell"},
        {".psd", "application/octet-stream"},
        {".psess", "application/xml"},
        {".psm", "application/octet-stream"},
        {".psp", "application/octet-stream"},
        {".pub", "application/x-mspublisher"},
        {".pwz", "application/vnd.ms-powerpoint"},
        {".qht", "text/x-html-insertion"},
        {".qhtm", "text/x-html-insertion"},
        {".qt", "video/quicktime"},
        {".qti", "image/x-quicktime"},
        {".qtif", "image/x-quicktime"},
        {".qtl", "application/x-quicktimeplayer"},
        {".qxd", "application/octet-stream"},
        {".ra", "audio/x-pn-realaudio"},
        {".ram", "audio/x-pn-realaudio"},
        {".rar", "application/octet-stream"},
        {".ras", "image/x-cmu-raster"},
        {".rat", "application/rat-file"},
        {".rc", "text/plain"},
        {".rc2", "text/plain"},
        {".rct", "text/plain"},
        {".rdlc", "application/xml"},
        {".resx", "application/xml"},
        {".rf", "image/vnd.rn-realflash"},
        {".rgb", "image/x-rgb"},
        {".rgs", "text/plain"},
        {".rm", "application/vnd.rn-realmedia"},
        {".rmi", "audio/mid"},
        {".rmp", "application/vnd.rn-rn_music_package"},
        {".roff", "application/x-troff"},
        {".rpm", "audio/x-pn-realaudio-plugin"},
        {".rqy", "text/x-ms-rqy"},
        {".rtf", "application/rtf"},
        {".rtx", "text/richtext"},
        {".ruleset", "application/xml"},
        {".s", "text/plain"},
        {".safariextz", "application/x-safari-safariextz"},
        {".scd", "application/x-msschedule"},
        {".sct", "text/scriptlet"},
        {".sd2", "audio/x-sd2"},
        {".sdp", "application/sdp"},
        {".sea", "application/octet-stream"},
        {".searchConnector-ms", "application/windows-search-connector+xml"},
        {".setpay", "application/set-payment-initiation"},
        {".setreg", "application/set-registration-initiation"},
        {".settings", "application/xml"},
        {".sgimb", "application/x-sgimb"},
        {".sgml", "text/sgml"},
        {".sh", "application/x-sh"},
        {".shar", "application/x-shar"},
        {".shtml", "text/html"},
        {".sit", "application/x-stuffit"},
        {".sitemap", "application/xml"},
        {".skin", "application/xml"},
        {".sldm", "application/vnd.ms-powerpoint.slide.macroEnabled.12"},
        {".sldx", "application/vnd.openxmlformats-officedocument.presentationml.slide"},
        {".slk", "application/vnd.ms-excel"},
        {".sln", "text/plain"},
        {".slupkg-ms", "application/x-ms-license"},
        {".smd", "audio/x-smd"},
        {".smi", "application/octet-stream"},
        {".smx", "audio/x-smd"},
        {".smz", "audio/x-smd"},
        {".snd", "audio/basic"},
        {".snippet", "application/xml"},
        {".snp", "application/octet-stream"},
        {".sol", "text/plain"},
        {".sor", "text/plain"},
        {".spc", "application/x-pkcs7-certificates"},
        {".spl", "application/futuresplash"},
        {".src", "application/x-wais-source"},
        {".srf", "text/plain"},
        {".SSISDeploymentManifest", "text/xml"},
        {".ssm", "application/streamingmedia"},
        {".sst", "application/vnd.ms-pki.certstore"},
        {".stl", "application/vnd.ms-pki.stl"},
        {".sv4cpio", "application/x-sv4cpio"},
        {".sv4crc", "application/x-sv4crc"},
        {".svc", "application/xml"},
        {".swf", "application/x-shockwave-flash"},
        {".t", "application/x-troff"},
        {".tar", "application/x-tar"},
        {".tcl", "application/x-tcl"},
        {".testrunconfig", "application/xml"},
        {".testsettings", "application/xml"},
        {".tex", "application/x-tex"},
        {".texi", "application/x-texinfo"},
        {".texinfo", "application/x-texinfo"},
        {".tgz", "application/x-compressed"},
        {".thmx", "application/vnd.ms-officetheme"},
        {".thn", "application/octet-stream"},
        {".tif", "image/tiff"},
        {".tiff", "image/tiff"},
        {".tlh", "text/plain"},
        {".tli", "text/plain"},
        {".toc", "application/octet-stream"},
        {".tr", "application/x-troff"},
        {".trm", "application/x-msterminal"},
        {".trx", "application/xml"},
        {".ts", "video/vnd.dlna.mpeg-tts"},
        {".tsv", "text/tab-separated-values"},
        {".ttf", "application/octet-stream"},
        {".tts", "video/vnd.dlna.mpeg-tts"},
        {".txt", "text/plain"},
        {".u32", "application/octet-stream"},
        {".uls", "text/iuls"},
        {".user", "text/plain"},
        {".ustar", "application/x-ustar"},
        {".vb", "text/plain"},
        {".vbdproj", "text/plain"},
        {".vbk", "video/mpeg"},
        {".vbproj", "text/plain"},
        {".vbs", "text/vbscript"},
        {".vcf", "text/x-vcard"},
        {".vcproj", "Application/xml"},
        {".vcs", "text/plain"},
        {".vcxproj", "Application/xml"},
        {".vddproj", "text/plain"},
        {".vdp", "text/plain"},
        {".vdproj", "text/plain"},
        {".vdx", "application/vnd.ms-visio.viewer"},
        {".vml", "text/xml"},
        {".vscontent", "application/xml"},
        {".vsct", "text/xml"},
        {".vsd", "application/vnd.visio"},
        {".vsi", "application/ms-vsi"},
        {".vsix", "application/vsix"},
        {".vsixlangpack", "text/xml"},
        {".vsixmanifest", "text/xml"},
        {".vsmdi", "application/xml"},
        {".vspscc", "text/plain"},
        {".vss", "application/vnd.visio"},
        {".vsscc", "text/plain"},
        {".vssettings", "text/xml"},
        {".vssscc", "text/plain"},
        {".vst", "application/vnd.visio"},
        {".vstemplate", "text/xml"},
        {".vsto", "application/x-ms-vsto"},
        {".vsw", "application/vnd.visio"},
        {".vsx", "application/vnd.visio"},
        {".vtx", "application/vnd.visio"},
        {".wav", "audio/wav"},
        {".wave", "audio/wav"},
        {".wax", "audio/x-ms-wax"},
        {".wbk", "application/msword"},
        {".wbmp", "image/vnd.wap.wbmp"},
        {".wcm", "application/vnd.ms-works"},
        {".wdb", "application/vnd.ms-works"},
        {".wdp", "image/vnd.ms-photo"},
        {".webarchive", "application/x-safari-webarchive"},
        {".webtest", "application/xml"},
        {".wiq", "application/xml"},
        {".wiz", "application/msword"},
        {".wks", "application/vnd.ms-works"},
        {".WLMP", "application/wlmoviemaker"},
        {".wlpginstall", "application/x-wlpg-detect"},
        {".wlpginstall3", "application/x-wlpg3-detect"},
        {".wm", "video/x-ms-wm"},
        {".wma", "audio/x-ms-wma"},
        {".wmd", "application/x-ms-wmd"},
        {".wmf", "application/x-msmetafile"},
        {".wml", "text/vnd.wap.wml"},
        {".wmlc", "application/vnd.wap.wmlc"},
        {".wmls", "text/vnd.wap.wmlscript"},
        {".wmlsc", "application/vnd.wap.wmlscriptc"},
        {".wmp", "video/x-ms-wmp"},
        {".wmv", "video/x-ms-wmv"},
        {".wmx", "video/x-ms-wmx"},
        {".wmz", "application/x-ms-wmz"},
        {".wpl", "application/vnd.ms-wpl"},
        {".wps", "application/vnd.ms-works"},
        {".wri", "application/x-mswrite"},
        {".wrl", "x-world/x-vrml"},
        {".wrz", "x-world/x-vrml"},
        {".wsc", "text/scriptlet"},
        {".wsdl", "text/xml"},
        {".wvx", "video/x-ms-wvx"},
        {".x", "application/directx"},
        {".xaf", "x-world/x-vrml"},
        {".xaml", "application/xaml+xml"},
        {".xap", "application/x-silverlight-app"},
        {".xbap", "application/x-ms-xbap"},
        {".xbm", "image/x-xbitmap"},
        {".xdr", "text/plain"},
        {".xht", "application/xhtml+xml"},
        {".xhtml", "application/xhtml+xml"},
        {".xla", "application/vnd.ms-excel"},
        {".xlam", "application/vnd.ms-excel.addin.macroEnabled.12"},
        {".xlc", "application/vnd.ms-excel"},
        {".xld", "application/vnd.ms-excel"},
        {".xlk", "application/vnd.ms-excel"},
        {".xll", "application/vnd.ms-excel"},
        {".xlm", "application/vnd.ms-excel"},
        {".xls", "application/vnd.ms-excel"},
        {".xlsb", "application/vnd.ms-excel.sheet.binary.macroEnabled.12"},
        {".xlsm", "application/vnd.ms-excel.sheet.macroEnabled.12"},
        {".xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"},
        {".xlt", "application/vnd.ms-excel"},
        {".xltm", "application/vnd.ms-excel.template.macroEnabled.12"},
        {".xltx", "application/vnd.openxmlformats-officedocument.spreadsheetml.template"},
        {".xlw", "application/vnd.ms-excel"},
        {".xml", "text/xml"},
        {".xmta", "application/xml"},
        {".xof", "x-world/x-vrml"},
        {".XOML", "text/plain"},
        {".xpm", "image/x-xpixmap"},
        {".xps", "application/vnd.ms-xpsdocument"},
        {".xrm-ms", "text/xml"},
        {".xsc", "application/xml"},
        {".xsd", "text/xml"},
        {".xsf", "text/xml"},
        {".xsl", "text/xml"},
        {".xslt", "text/xml"},
        {".xsn", "application/octet-stream"},
        {".xss", "application/xml"},
        {".xtp", "application/octet-stream"},
        {".xwd", "image/x-xwindowdump"},
        {".z", "application/x-compress"},
        {".zip", "application/x-zip-compressed"},
        #endregion

        };

        public static string GetMimeType(string extension)
        {
            if (extension == null)
            {
                throw new ArgumentNullException("extension");
            }

            if (!extension.StartsWith("."))
            {
                extension = "." + extension;
            }

            string mime;

            return _mappings.TryGetValue(extension, out mime) ? mime : "application/octet-stream";
        }
    }
}
