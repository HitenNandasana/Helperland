#pragma checksum "C:\Users\pci140\Desktop\Project\Helperland\helperland_project\helperland_project\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff601d897edb8aa912236461fa3da9b3d5ccfe47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\pci140\Desktop\Project\Helperland\helperland_project\helperland_project\Views\_ViewImports.cshtml"
using helperland_project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pci140\Desktop\Project\Helperland\helperland_project\helperland_project\Views\_ViewImports.cshtml"
using helperland_project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\pci140\Desktop\Project\Helperland\helperland_project\helperland_project\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff601d897edb8aa912236461fa3da9b3d5ccfe47", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5df425dc63dc6103c2fe5675393a852b16fa182f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BookService", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Let\'s Book a Cleaner"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("blue-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\pci140\Desktop\Project\Helperland\helperland_project\helperland_project\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Homepage";
    Layout = "~/Views/Shared/homepagelayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>
    <section class=""hero-banner-section"" style=""background-image: url(/images/hero-banner.jpg);"">
        <div class=""container"">
            <h1>Do not feel like housework?</h1>
            <div class=""step-wrapper ms-5"">
                <div class=""row"">
                    <div class=""step"">
                        <p>Great! Book now for Helperland and enjoy the benefits</p>
                    </div>
                </div>
            </div>
            <ul>
                <li>certified & insured helper</li>
                <li>easy booking procedure</li>
                <li>friendly customer service</li>
                <li>secure online payment method</li>
            </ul>
            <div class=""btn-wrapper text-center"">
");
#nullable restore
#line 26 "C:\Users\pci140\Desktop\Project\Helperland\helperland_project\helperland_project\Views\Home\Index.cshtml"
                 if (HttpContextAccessor.HttpContext.Session.GetString("UserTypeId") == "1" || HttpContextAccessor.HttpContext.Session.GetString("UserTypeId") == null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff601d897edb8aa912236461fa3da9b3d5ccfe476178", async() => {
                WriteLiteral("Let\'s Book a Cleaner");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 29 "C:\Users\pci140\Desktop\Project\Helperland\helperland_project\helperland_project\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
            <div class=""step-wrapper"">
                <div class=""row justify-content-center flex-wrap"">
                    <div class=""col-lg-3 col-6 process-item-1 full-width"">
                        <div class=""step"">
                            <span>
                                <img src=""/images/enter-postcode-icon.png"" alt=""Enter Postcode"">
                            </span>
                            <p>Enter your postcode</p>
                        </div>
                    </div>
                    <div class=""col-lg-3 col-6 process-item-2 full-width"">
                        <div class=""step"">
                            <span>
                                <img src=""/images/select-plan-icon.png"" alt=""Select Plan"">
                            </span>
                            <p>Select your plan</p>
                        </div>
                    </div>
                    <div class=""col-lg-3 col-6 process-item-3 full-width"">
               ");
            WriteLiteral(@"         <div class=""step"">
                            <span>
                                <img src=""/images/pay-securely-icon.png"" alt=""Pay Securely"">
                            </span>
                            <p>Pay securely online</p>
                        </div>
                    </div>
                    <div class=""col-lg-3 col-6 process-item-4 full-width"">
                        <div class=""step"">
                            <span>
                                <img src=""/images/amazing-service-icon.png"" alt=""Amazing service"">
                            </span>
                            <p>Enjoy amazing service</p>
                        </div>
                    </div>


                </div>
            </div>
        </div>
        <div class=""scroll-link-wrapper"">
            <a href=""#"" title=""Scroll Down"" class=""scroll-link"">
                <img src=""/images/white-down-arrow.png"" alt=""Scroll-down"">
            </a>
        </div>
    </section>

");
            WriteLiteral(@"    <section class=""why-helperhand scroll-section"">
        <div class=""container"">
            <h2 class=""text-center"">Convince yourself!</h2>
            <div class=""row justify-content-center helperhand-wrapper"">
                <div class=""col-lg-4 col-sm-6 text-center"">
                    <div class=""img-block"">
                        <img src=""/images/professionals.png"" alt=""Professionals"">
                    </div>
                    <h3 class=""justify-content-center d-flex align-items-center"">

                        Friendly & Certified Helpers
                    </h3>
                    <p>We want you to be completely satisfied with our service and feel comfortable at home. 
                    In order to guarantee this, our helpers go through a test procedure.
                    Only when the cleaners meet our high standards, they may call themselves Helper.</p>
                </div>
                <div class=""col-lg-4 col-sm-6 text-center"">
                    <div clas");
            WriteLiteral(@"s=""img-block"">
                        <img src=""/images/online-payment.png"" alt=""Online Payment"">
                    </div>
                    <h3 class=""justify-content-center  d-flex align-items-center"">Transparent and secure payment</h3>
                    <p>
                        We have transparent prices, you do not have to scratch money or money on the sideboard Leave it: 
                        Pay your helper easily and securely via the online payment method. 
                        You will also receive an invoice for each completed cleaning.
                    </p>
                </div>
                <div class=""col-lg-4 col-sm-6 text-center"">
                    <div class=""img-block"">
                        <img src=""/images/customer-service.png"" alt=""Customer service"">
                    </div>
                    <h3 class=""justify-content-center  d-flex align-items-center"">We're here for you</h3>
                    <p>
                        You have a question");
            WriteLiteral(@" or need assistance with the booking process? 
                        Our customer service is happy to help and advise you. 
                        How you can reach us you will find out when you look under ""Contact"". 
                        We look forward to hearing from you or reading.
                    </p>
                </div>
            </div>
        </div>
    </section>

    <section class=""blog-section"">
        <div class=""container"">
            <div class=""blog-description-block"">
                <div class=""row align-items-center"">
                    <div class=""col-lg-7 col-md-6"">
                        <h2 class=""h3"">We do not know what makes you happy, but ...</h2>
                        <p>
                            If it's not dusting off, our friendly helpers will free you from this burden - 
                            do not worry anymore about spending valuable time doing housework, but savor life, 
                            you're well worth your time ");
            WriteLiteral(@"with beautiful experiences. 
                            Free yourself and enjoy the gained time: Go celebrate, relax, play with your children, 
                            meet friends or dare to jump on the bungee.
                            Other leisure ideas and exclusive events can be found in our blog - guaranteed free from 
                            dust and cleaning tips!
                        </p>
                    </div>
                    <div class=""col-lg-5 col-md-6"">
                        <div class=""image-wrapper"">
                            <img src=""/images/blog-decription-image.png"" alt=""Blog description"">
                        </div>
                    </div>
                </div>
            </div>
            <div class=""our-blog-block"">
                <h2 class=""text-center"">Our Blog</h2>
                <div class=""row blog-wrapper"">
                    <div class=""col-lg-4 col-sm-6 blog-detail-outer"">
                        <div class=""blog-detail"">");
            WriteLiteral(@"
                            <div class=""blog-image"">
                                <img src=""/images/blog-image-1.png"" alt=""blog-image"">
                            </div>
                            <div class=""blog-content"">
                                <h3>Lorem ipsum dolor sit amet</h3>
                                <span>January 28, 2019</span>
                                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed fermentum metus pulvinar aliquet.</p>
                                <a href=""#"" title=""Read More"" class=""arrow-link"">Read More<em><img src=""/images/right-arrow-gray.png"" alt=""right arrow""></em></a>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-4 col-sm-6 blog-detail-outer"">
                        <div class=""blog-detail"">
                            <div class=""blog-image"">
                                <img src=""/images/blog-image-2.png"" alt=""blog-image"">
 ");
            WriteLiteral(@"                           </div>
                            <div class=""blog-content"">
                                <h3>Lorem ipsum dolor sit amet</h3>
                                <span>January 28, 2019</span>
                                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed fermentum metus pulvinar aliquet.</p>
                                <a href=""#"" title=""Read More"" class=""arrow-link"">Read More<em><img src=""/images/right-arrow-gray.png"" alt=""right arrow""></em></a>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-4 col-sm-6 blog-detail-outer"">
                        <div class=""blog-detail"">
                            <div class=""blog-image"">
                                <img src=""/images/blog-image-3.png"" alt=""blog-image"">
                            </div>
                            <div class=""blog-content"">
                                <h3>Lorem ipsum dolo");
            WriteLiteral(@"r sit amet</h3>
                                <span>January 28, 2019</span>
                                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed fermentum metus pulvinar aliquet.</p>
                                <a href=""#"" title=""Read More"" class=""arrow-link"">Read More<em><img src=""/images/right-arrow-gray.png"" alt=""right arrow""></em></a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <section class=""customer-section"">
        <div class=""container"">
            <h2 class=""text-center"">What Our Customers Say</h2>
            <div class=""row customer-wrapper"">
                <div class=""col-lg-4 col-sm-6"">
                    <div class=""customer-inner"">
                        <em class=""message-infor"">
                            <img src=""/images/message.png"" alt=""Message Info"">
                        </em>
                        ");
            WriteLiteral(@"<div class=""person-info d-flex align-items-center"">
                            <div class=""person-image"">
                                <img src=""/images/lary-watson.png"" alt=""Lary Watson"">
                            </div>
                            <div class=""person-content"">
                                <span class=""person-name"">Lary Watson</span>
                                <span class=""person-city"">Manchester</span>
                            </div>
                        </div>
                        <div class=""person-detail"">
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed fermentum metus pulvinar aliquet consequat. Praesent nec malesuada nibh.</p>
                            <p>Nullam et metus congue, auctor augue sit amet, consectetur tortor.</p>
                            <a href=""#"" title=""Read More"" class=""arrow-link"">Read More <em><img src=""/images/right-arrow-gray.png"" alt=""Right Arrow""></em></a>
                        <");
            WriteLiteral(@"/div>
                    </div>
                </div>
                <div class=""col-lg-4 col-sm-6"">
                    <div class=""customer-inner"">
                        <em class=""message-infor"">
                            <img src=""/images/message.png"" alt=""Message Info"">
                        </em>
                        <div class=""person-info d-flex align-items-center"">
                            <div class=""person-image"">
                                <img src=""/images/john-smith.png"" alt=""John Smith"">
                            </div>
                            <div class=""person-content"">
                                <span class=""person-name"">John Smith</span>
                                <span class=""person-city"">Manchester</span>
                            </div>
                        </div>
                        <div class=""person-detail"">
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed fermentum metus pulvinar");
            WriteLiteral(@" aliquet consequat. Praesent nec malesuada nibh.</p>
                            <p>Nullam et metus congue, auctor augue sit amet, consectetur tortor.</p>
                            <a href=""#"" title=""Read More"" class=""arrow-link"">Read More <em><img src=""/images/right-arrow-gray.png"" alt=""Right Arrow""></em></a>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-4 col-sm-6"">
                    <div class=""customer-inner"">
                        <em class=""message-infor"">
                            <img src=""/images/message.png"" alt=""Message Info"">
                        </em>
                        <div class=""person-info d-flex align-items-center"">
                            <div class=""person-image"">
                                <img src=""/images/lars-johnson.png"" alt=""Lars Johnson"">
                            </div>
                            <div class=""person-content"">
                                <span class=""");
            WriteLiteral(@"person-name"">Lars Johnson</span>
                                <span class=""person-city"">Manchester</span>
                            </div>
                        </div>
                        <div class=""person-detail"">
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed fermentum metus pulvinar aliquet consequat. Praesent nec malesuada nibh.</p>
                            <p>Nullam et metus congue, auctor augue sit amet, consectetur tortor.</p>
                            <a href=""#"" title=""Read More"" class=""arrow-link"">Read More <em><img src=""/images/right-arrow-gray.png"" alt=""Right Arrow""></em></a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <section class=""our-news-letter"">
        <div class=""container text-center"">
            <a href=""#"" class=""scroll-top""><img src=""/images/up-arrow.png"" alt=""up-arrow""></a>
            <a href=""#"" class=""message-bo");
            WriteLiteral(@"at""><img src=""/images/message-boat.png"" alt=""message-boat""></a>
            <h2>GET OUR NEWSLETTER</h2>
            <div class=""form-row d-flex justify-content-center align-items-center"">
                <div class=""form-group"">
                    <label for=""email"" style=""display: none;"">YOUR EMAIL</label>
                    <input type=""text"" placeholder=""YOUR EMAIL"" id=""email"" class=""form-control"">
                </div>
                <div class=""btn-wrapper"">
                    <button class=""red-btn"">Submit</button>
                </div>
            </div>
        </div>
    </section>
</main>

");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
