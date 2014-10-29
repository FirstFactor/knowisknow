<%@ Page Title="" Language="C#" MasterPageFile="~/KnowIsKnow.Master" AutoEventWireup="true" CodeBehind="ProCenter.aspx.cs" Inherits="KnowIsKnow.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="Stylesheet" href="js/uploadify.css" />

    <link href="css/ProCenter.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="js/swfobject.js"></script>
    <script type="text/javascript" src="js/jquery.uploadify.min.js"></script>
    <script type="text/javascript" src="js/procenter.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="mengban">
    </div>
    <div id="uploadArea">
        <div id="upAreaHeader">
            <div id="upAreaClose">X</div>
        </div>
        <input type="file" name="uploadify" id="uploadify" />
        <a href="javascript:$('#uploadify').uploadifyUpload()" id="uploadbtn">上传</a>| <a href="javascript:$('#uploadify').uploadifyClearQueue()">取消上传</a>
        <div id="fileQueue"></div>
    </div>

    <div class="wtzg-wrap wtzu-main">
        <div class="wtzu-main-content-inner">
            <div class="wtzm-profile-header">
                <div class="wtzm-profile-header-main">
                    <div class="wt-top">
                        <div class="wtellipsis" uid="<%=userid %>">
                            <span class="wtname"><%=nickname %></span>
                            <span>,</span>
                            <span id="wtqianming" title="爱好世间美好的一切"><%=shuoshuo %></span>
                        </div>
                    </div>
                    <div class="wtclearfix">
                        <div class="wtzm-profile-header-avatar-container">
                            <img src="<%=headimg %>" class="wtzm-profile-header-img" />
                        </div>
                        <div class="wtzm-profile-header-info">
                            <div class="wtitems">
                                <div class="wtit">
                                    <i class="wticon wticon-profile-location"></i>
                                    <span class="wtinfo-wrap">
                                        <span class="wtlocation"><a class="wtzg-link-litblue-normal">填写居住地</a></span>
                                        <span class="wtbusiness wthangye">
                                            <a class="wttopic-link wtzg-link-litblue-normal">填写行业</a>
                                        </span>
                                        <span class="wtbusiness"><i class="wticon  wticon-male wticon-profile-male"></i></span>
                                        <a class="wtzu-edit-button wtzubtn"><i class="wtzu-edit-button-icon"></i><span class="wtedit-msg">修改</span></a>
                                    </span>
                                    <span class="wtedit-wrap">
                                        <span class="wttopic-input-wrap">
                                            <input class="wtzg-form-text-input wtzg-form-text-input0" autocomplete="off" placeholder="居住地" aria-label="居住地" value="<%=address%>" />
                                        </span>
                                        <div class="wtbusiness-selection">
                                            <select name="business" class="wtbusiness-selection2">

                                                <option value="<%=job%>"><%=job%></option>
                                                <option value="选择行业">选择行业</option>
                                                <option value="高新科技">高新科技</option>
                                                <option value="互联网">&nbsp;&nbsp;&nbsp;互联网</option>
                                                <option value="电子商务">&nbsp;&nbsp;&nbsp;电子商务</option>
                                                <option value="电子游戏">&nbsp;&nbsp;&nbsp;电子游戏</option>
                                                <option value="计算机软件">&nbsp;&nbsp;&nbsp;计算机软件</option>
                                                <option value="计算机硬件">&nbsp;&nbsp;&nbsp;计算机硬件</option>
                                                <option value="信息传媒">信息传媒</option>
                                                <option value="出版业">&nbsp;&nbsp;&nbsp;出版业</option>
                                                <option value="电影录音">&nbsp;&nbsp;&nbsp;电影录音</option>
                                                <option value="广播电视">&nbsp;&nbsp;&nbsp;广播电视</option>
                                                <option value="通信">&nbsp;&nbsp;&nbsp;通信</option>
                                                <option value="金融">金融</option>
                                                <option value="银行">&nbsp;&nbsp;&nbsp;银行</option>
                                                <option value="资本投资">&nbsp;&nbsp;&nbsp;资本投资</option>
                                                <option value="证券投资">&nbsp;&nbsp;&nbsp;证券投资</option>
                                                <option value="保险">&nbsp;&nbsp;&nbsp;保险</option>
                                                <option value="信贷">&nbsp;&nbsp;&nbsp;信贷</option>
                                                <option value="财务">&nbsp;&nbsp;&nbsp;财务</option>
                                                <option value="审计">&nbsp;&nbsp;&nbsp;审计</option>
                                                <option value="服务业">服务业</option>
                                                <option value="法律">&nbsp;&nbsp;&nbsp;法律</option>
                                                <option value="餐饮">&nbsp;&nbsp;&nbsp;餐饮</option>
                                                <option value="酒店">&nbsp;&nbsp;&nbsp;酒店</option>
                                                <option value="旅游">&nbsp;&nbsp;&nbsp;旅游</option>
                                                <option value="广告">&nbsp;&nbsp;&nbsp;广告</option>
                                                <option value="公关">&nbsp;&nbsp;&nbsp;公关</option>
                                                <option value="景观">&nbsp;&nbsp;&nbsp;景观</option>
                                                <option value="咨询分析">&nbsp;&nbsp;&nbsp;咨询分析</option>
                                                <option value="市场推广">&nbsp;&nbsp;&nbsp;市场推广</option>
                                                <option value="人力资源">&nbsp;&nbsp;&nbsp;人力资源</option>
                                                <option value="社工服务">&nbsp;&nbsp;&nbsp;社工服务</option>
                                                <option value="养老服务">&nbsp;&nbsp;&nbsp;养老服务</option>
                                                <option value="教育">教育</option>
                                                <option value="高等教育">&nbsp;&nbsp;&nbsp;高等教育</option>
                                                <option value="基础教育">&nbsp;&nbsp;&nbsp;基础教育</option>
                                                <option value="职业教育">&nbsp;&nbsp;&nbsp;职业教育</option>
                                                <option value="幼儿教育">&nbsp;&nbsp;&nbsp;幼儿教育</option>
                                                <option value="特殊教育">&nbsp;&nbsp;&nbsp;特殊教育</option>
                                                <option value="培训">&nbsp;&nbsp;&nbsp;培训</option>
                                                <option value="医疗服务">医疗服务</option>
                                                <option value="临床医疗">&nbsp;&nbsp;&nbsp;临床医疗</option>
                                                <option value="制药">&nbsp;&nbsp;&nbsp;制药</option>
                                                <option value="保健">&nbsp;&nbsp;&nbsp;保健</option>
                                                <option value="美容">&nbsp;&nbsp;&nbsp;美容</option>
                                                <option value="医疗器材">&nbsp;&nbsp;&nbsp;医疗器材</option>
                                                <option value="生物工程">&nbsp;&nbsp;&nbsp;生物工程</option>
                                                <option value="疗养服务">&nbsp;&nbsp;&nbsp;疗养服务</option>
                                                <option value="护理服务">&nbsp;&nbsp;&nbsp;护理服务</option>
                                                <option value="艺术娱乐">艺术娱乐</option>
                                                <option value="创意艺术">&nbsp;&nbsp;&nbsp;创意艺术</option>
                                                <option value="体育健身">&nbsp;&nbsp;&nbsp;体育健身</option>
                                                <option value="娱乐休闲">&nbsp;&nbsp;&nbsp;娱乐休闲</option>
                                                <option value="图书馆">&nbsp;&nbsp;&nbsp;图书馆</option>
                                                <option value="博物馆">&nbsp;&nbsp;&nbsp;博物馆</option>
                                                <option value="策展">&nbsp;&nbsp;&nbsp;策展</option>
                                                <option value="博彩">&nbsp;&nbsp;&nbsp;博彩</option>
                                                <option value="制造加工">制造加工</option>
                                                <option value="食品饮料业">&nbsp;&nbsp;&nbsp;食品饮料业</option>
                                                <option value="纺织皮革业">&nbsp;&nbsp;&nbsp;纺织皮革业</option>
                                                <option value="服装业">&nbsp;&nbsp;&nbsp;服装业</option>
                                                <option value="烟草业">&nbsp;&nbsp;&nbsp;烟草业</option>
                                                <option value="造纸业">&nbsp;&nbsp;&nbsp;造纸业</option>
                                                <option value="印刷业">&nbsp;&nbsp;&nbsp;印刷业</option>
                                                <option value="化工业">&nbsp;&nbsp;&nbsp;化工业</option>
                                                <option value="汽车">&nbsp;&nbsp;&nbsp;汽车</option>
                                                <option value="家具">&nbsp;&nbsp;&nbsp;家具</option>
                                                <option value="电子电器">&nbsp;&nbsp;&nbsp;电子电器</option>
                                                <option value="机械设备">&nbsp;&nbsp;&nbsp;机械设备</option>
                                                <option value="塑料工业">&nbsp;&nbsp;&nbsp;塑料工业</option>
                                                <option value="金属加工">&nbsp;&nbsp;&nbsp;金属加工</option>
                                                <option value="军火">&nbsp;&nbsp;&nbsp;军火</option>
                                                <option value="地产建筑">地产建筑</option>
                                                <option value="房地产">&nbsp;&nbsp;&nbsp;房地产</option>
                                                <option value="装饰装潢">&nbsp;&nbsp;&nbsp;装饰装潢</option>
                                                <option value="物业服务">&nbsp;&nbsp;&nbsp;物业服务</option>
                                                <option value="特殊建造">&nbsp;&nbsp;&nbsp;特殊建造</option>
                                                <option value="建筑设备">&nbsp;&nbsp;&nbsp;建筑设备</option>
                                                <option value="贸易零售">贸易零售</option>
                                                <option value="零售">&nbsp;&nbsp;&nbsp;零售</option>
                                                <option value="大宗交易">&nbsp;&nbsp;&nbsp;大宗交易</option>
                                                <option value="进出口贸易">&nbsp;&nbsp;&nbsp;进出口贸易</option>
                                                <option value="公共服务">公共服务</option>
                                                <option value="政府">&nbsp;&nbsp;&nbsp;政府</option>
                                                <option value="国防军事">&nbsp;&nbsp;&nbsp;国防军事</option>
                                                <option value="航天">&nbsp;&nbsp;&nbsp;航天</option>
                                                <option value="科研">&nbsp;&nbsp;&nbsp;科研</option>
                                                <option value="给排水">&nbsp;&nbsp;&nbsp;给排水</option>
                                                <option value="水利能源">&nbsp;&nbsp;&nbsp;水利能源</option>
                                                <option value="电力电网">&nbsp;&nbsp;&nbsp;电力电网</option>
                                                <option value="公共管理">&nbsp;&nbsp;&nbsp;公共管理</option>
                                                <option value="环境保护">&nbsp;&nbsp;&nbsp;环境保护</option>
                                                <option value="非营利组织">&nbsp;&nbsp;&nbsp;非营利组织</option>
                                                <option value="开采冶金">开采冶金</option>
                                                <option value="煤炭工业">&nbsp;&nbsp;&nbsp;煤炭工业</option>
                                                <option value="石油工业">&nbsp;&nbsp;&nbsp;石油工业</option>
                                                <option value="黑色金属">&nbsp;&nbsp;&nbsp;黑色金属</option>
                                                <option value="有色金属">&nbsp;&nbsp;&nbsp;有色金属</option>
                                                <option value="土砂石开采">&nbsp;&nbsp;&nbsp;土砂石开采</option>
                                                <option value="地热开采">&nbsp;&nbsp;&nbsp;地热开采</option>
                                                <option value="交通仓储">交通仓储</option>
                                                <option value="邮政">&nbsp;&nbsp;&nbsp;邮政</option>
                                                <option value="物流递送">&nbsp;&nbsp;&nbsp;物流递送</option>
                                                <option value="地面运输">&nbsp;&nbsp;&nbsp;地面运输</option>
                                                <option value="铁路运输">&nbsp;&nbsp;&nbsp;铁路运输</option>
                                                <option value="管线运输">&nbsp;&nbsp;&nbsp;管线运输</option>
                                                <option value="航运业">&nbsp;&nbsp;&nbsp;航运业</option>
                                                <option value="民用航空业">&nbsp;&nbsp;&nbsp;民用航空业</option>
                                                <option value="农林牧渔">农林牧渔</option>
                                                <option value="种植业">&nbsp;&nbsp;&nbsp;种植业</option>
                                                <option value="畜牧养殖业">&nbsp;&nbsp;&nbsp;畜牧养殖业</option>
                                                <option value="林业">&nbsp;&nbsp;&nbsp;林业</option>
                                                <option value="渔业">&nbsp;&nbsp;&nbsp;渔业</option>


                                            </select>
                                        </div>
                                        <span class="wtzg-bull">|</span><span id="wtsp" style="display: none" xingbie="<%=gender%>"></span>
                                        <input type="radio" name="gender1" value="1" class="male" />
                                        男&nbsp;&nbsp;
										<input type="radio" name="gender1" class="female" />
                                        女
										<a href="javascript:;" class="wtzg-btn-blue wtbtnblue1" name="save">确定</a>

                                    </span>
                                </div>
                                <div class="wtitem wtempty wtit2">
                                    <i class="wticon wticon-profile-company"></i>
                                    <span class="wtinfo-empty-wrap wtinfo2 wtinfo21"><a class="wtzg-link-litblue-normal">填写工作信息</a></span>
                                    <span class="wtinfo-empty-wrap wtinfo2 wtbusiness wtinfo22"><a class="wtzg-link-litblue-normal">填写职位</a></span>
                                    <span class="wtedit-wrap2">
                                        <span class="wttopic-input-wrap">
                                            <input class="wtzg-form-text-input wtzg-form-text-input2" autocomplete="off" placeholder="公司或组织名称" aria-label="公司或组织名称" value="<%=company%>" />
                                        </span>
                                        <span class="wttopic-input-wrap">
                                            <input class="wtzg-form-text-input wtzg-form-text-input3" autocomplete="off" placeholder="你的职位" aria-label="你的职位" value="<%=position%>" />
                                        </span>
                                        <a class="wtzg-btn-blue wtbtnblue2" name="save">确定</a>
                                    </span>
                                </div>
                                <div class="wtitem wtempty ">
                                    <i class="wticon wticon-profile-education"></i>
                                    <span class="wtinfo-empty-wrap wtinfo3 wtinfo31"><a class="wtzg-link-litblue-normal">填写教育信息</a></span>
                                    <span class="wtinfo-empty-wrap wtinfo3 wtbusiness wtinfo32"><a class="wtzg-link-litblue-normal">专业方向</a></span>
                                    <span class="wtedit-wrap3">
                                        <span class="wttopic-input-wrap">
                                            <input class="wtzg-form-text-input wtzg-form-text-input4" autocomplete="off" placeholder="学校或教育机构" aria-label="学校或教育机构" value="<%=academy%>" />
                                        </span>
                                        <span class="wttopic-input-wrap">
                                            <input class="wtzg-form-text-input wtzg-form-text-input5" autocomplete="off" placeholder="专业方向" aria-label="专业方向" value="<%=major%>" />
                                        </span>
                                        <a class="wtzg-btn-blue wtbtnblue3" name="save">确定</a>
                                    </span>
                                </div>
                                <a class="wtzm-profile-header-user-detail wtzg-link-litblue-normal"></a>
                            </div>
                            <div class="wtzm-profile-header-description">
                                <span class="wtinfo-empty-wrap wtgerenjianjie">
                                    <a name="edit" class="wtzg-link-litblue-normal">
                                        <i class="wtzg-icon wtzg-icon-edit-button-blue wticon"></i>
                                        <span>填写个人简介</span>
                                    </a>
                                </span>
                                <span class="wtedit-wrap4">
                                    <div class="wtzm-editable-editor-outer">
                                        <div class="wtzm-editable-editor-inner wtzg-form-text-input">
                                            <textarea name="description" class="wtzm-editable-editor-input1 wtzm-editable-editor-input" style="white-space: pre;"><%=probio%></textarea>
                                        </div>
                                    </div>
                                    <a class="wtzg-btn-blue wtbtnblue" name="save">确定</a>
                                </span>
                            </div>
                        </div>
                        <br style="clear: both;" />
                    </div>
                </div>
                <div class="wtzm-profile-header-operation wtzg-clear">
                    <div class="wtzm-profile-header-info-list">
                        <span class="wtzm-profile-header-info-title">获得</span>
                        <span class="wtzm-profile-header-user-agree">
                            <span class="wtzm-profile-header-icon2 wticon"></span>
                            <strong class="wthuodezan">0</strong>
                            <span>赞同</span>
                        </span>
                        <span class="wtzm-profile-header-user-agree">
                            <span class="wtzm-profile-header-icon3 wticon"></span>
                            <strong class="wthuodeganxie">0</strong>
                            <span>感谢</span>
                        </span>
                        <a class="wtzg-right wtzg-link-litblue-normal" id="wtbianjiwodeziliao">
                            <i class="wtzg-icon-edit-button-blue wticon"></i>
                            <span>编辑我的资料</span>
                        </a>
                    </div>

                </div>
                <div class="wtprofile-navbar">
                    <a class="wtitemm  wtactive">
                        <i class="wticon wticon-profile-tab-home"></i>
                    </a>
                    <a class="wtitemm" href="MyQuestion.aspx">
                        <span>提问</span>
                        <span class="wtnum"><%=myquestion %></span>
                    </a>
                    <a class="wtitemm">
                        <span>回答</span>
                        <span class="wtnum"><%=myreply %></span>
                    </a>
                    <a class="wtitemm">
                        <span>专栏文章</span>
                        <span class="wtnum">0</span>
                    </a>
                    <a class="wtitemm">
                        <span>收藏</span>
                        <span class="wtnum">0</span>
                    </a>
                    <a class="wtitemm">
                        <span>公共编辑</span>
                        <span class="wtnum">0</span>
                    </a>

                </div>
            </div>
            <div class="wtzm-profile-section-wrap">
                <div class="wtzm-profile-section-head">
                    <h2 class="wtzm-profile-section-title">最新动态</h2>
                </div>
                <div id="wtzh-profile-activity-page-list">
                    <asp:Repeater runat="server" ID="rtpcared">
                        <ItemTemplate>
                            <div class="wtzm-profile-section-item wtzm-item">
                                <span>关注了话题</span>
                                <a>
                                    <img src="<%# Eval("topicPicUrl") %>" class="wtpic" />
                                    <span><%# Eval("topicTitle") %></span>
                                </a>
                                <span class="wtweek">1周前</span>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>                    
                </div>
            </div>


        </div>
        <div class="wtzu-main-content-inner2">
            <div class="wtzm-profile-mbox wtziliao">
                <div class="wtzm-profile-module wtzg-clear">
                    <span class="wtzm-profile-progress-title">资料完善度</span>
                    <span class="wtzm-profile-progress-bar">
                        <span id="wtzm-profile-progress-anim">37%</span>
                    </span>
                </div>
            </div>
            <div id="wtzm-profile-details-editform">
                <div class="wtzm-profile-details wtzm-profile-mbox">
                    <div class="wtzm-profile-module wtzg-clear">
                        <a class="wtzg-link-litblue2 wtzg-right" id="wtfanhuigerenzhuye">返回个人主页</a>
                        <h2 class="wtzm-profile-mbox-title">
                            <a><%=nickname %></a>
                            <span>» 编辑个人资料</span>
                        </h2>
                    </div>
                    <div class="wtzm-profile-module wtzm-profile-details-editform-avatar">
                        <h3>头像</h3>
                        <div class="wtzm-profile-module-desc">
                            <dl class="wtzm-form-table">
                                <dt class="wtzm-form-table-head">
                                    <img class="wtzg-avatar-big" src="http://pic4.zhimg.com/da8e974dc_l.jpg" />
                                </dt>
                                <dd class="wtzm-form-table-field">
                                    <a class="wtzg-btn-blue wtprofile-edit-avatar-btn">选择头像</a>
                                    <div class="wtprofile-edit-avatar-tip wtzg-gray">支持 JPG、PNG、GIF 格式，不要超过 2M 。</div>
                                </dd>
                            </dl>
                        </div>
                    </div>
                    <div class="wtzm-profile-module wtzm-profile-details-editform-gender">
                        <h3>性别</h3>
                        <div class="wtzm-profile-module-desc2">
                            <div>
                                <div class="zqymale" style="width: 10px; height: 10px; line-height: 10px; text-align: center; float: left; background-color: #dedede;border:1px solid #bbbbbb;  cursor: pointer; margin-right: 20px;border-radius:50%;margin-top:5px;">
                                    <div class="wtlikebtn wtlikebtn1"></div>
                                </div>
                                <span style="display:block;float:left;margin-left:-15px;" >男</span>
                            </div>
                            <div>
                                <div class="zqyfemale" style="width: 10px; height:10px; line-height: 10px; text-align: center; float: left; background-color:#dedede;border:1px solid #bbbbbb; cursor: pointer;border-radius:50%;margin-left:15px;margin-top:5px;">
                                    <div class="wtlikebtn wtlikebtn2" ></div>
                                </div>
                                <span style="display:block;float:left;margin-left:5px;">女</span>
                            </div>
                            <input type="type" name="name" value="" runat="server" id="xingbie" style="display: none;" class="ssss" />
                            <input type="type" name="name" value="<%=gender %>"  id="xingbie11" style="display: none;" class="ssss" />

                        </div>
                    </div>
                    <div class="wtzm-profile-module wtzm-profile-details-editform-weibo">
                        <h3>社区绑定</h3>
                        <div class="wtzm-profile-module-desc">
                            <div class="wtzm-profile-edit-fieldset wtweibo-edit-wrap">
                                <label>
                                    <input type="radio" name="showhide" value="1" checked="checked" class="show" />
                                    显示&nbsp;&nbsp;
                                </label>
                                <label>
                                    <input type="radio" name="showhide" value="0" class="hide" />
                                    隐藏
                                </label>
                                <p class="wtdesc">你可以邀请好友加入知乎、回答问题，或把知乎上精彩问答分享到其他社区。</p>
                            </div>
                            <div class="wtsettings-item">
                                <div class="wtzu-settings-sina-bind">
                                    <a>绑定新浪微博帐号</a>
                                </div>
                            </div>
                            <div class="wtsettings-item">
                                <div class="wtzu-settings-qqconn-bind">
                                    <a>绑定 QQ 帐号</a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="wtzm-profile-module wtyijvhua">
                        <h3>一句话介绍</h3>
                        <div class="wtzm-profile-module-desc">
                            <div class="wtzm-profile-edit-fieldset">
                                <input class="wtzg-form-text-input" value="爱好世间美好的一切" />
                                <p class="wtdesc">例如：汽车制造 / 产品设计师 / 登山爱好者</p>
                            </div>
                        </div>
                    </div>
                    <div class="wtzm-profile-module wtzm-profile-details-editform-desc">
                        <h3>个人简介</h3>
                        <div class="wtzm-profile-module-desc">
                            <div class="wtzm-profile-edit-fieldset">
                                <div class="wtzm-editable-editor-wrap">
                                    <div class="wtzm-editable-editor-outer">
                                        <div class="wtzg-form-text-input wtzg-form-text-inputse">
                                            <textarea id="wtzm-profile-edit-description" name="wtzm-profile-edit-description" class="wtzm-editable-editor-input"><%=probio%></textarea>
                                        </div>
                                    </div>
                                    <p class="wtdesc">用一段话介绍你自己，会在你的个人页面显示</p>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="wtzm-profile-module wtsuozaihangye">
                        <h3>所在行业</h3>
                        <div class="wtzm-profile-module-desc">
                            <div class="wtzm-profile-edit-fieldset">
                                <div class="wtbusiness-selection">
                                    <select name="wth-business">

                                        <option value="<%=job%>"><%=job%></option>
                                        <option value="选择行业">选择行业</option>
                                        <option value="高新科技">高新科技</option>
                                        <option value="互联网">&nbsp;&nbsp;&nbsp;互联网</option>
                                        <option value="电子商务">&nbsp;&nbsp;&nbsp;电子商务</option>
                                        <option value="电子游戏">&nbsp;&nbsp;&nbsp;电子游戏</option>
                                        <option value="计算机软件">&nbsp;&nbsp;&nbsp;计算机软件</option>
                                        <option value="计算机硬件">&nbsp;&nbsp;&nbsp;计算机硬件</option>
                                        <option value="信息传媒">信息传媒</option>
                                        <option value="出版业">&nbsp;&nbsp;&nbsp;出版业</option>
                                        <option value="电影录音">&nbsp;&nbsp;&nbsp;电影录音</option>
                                        <option value="广播电视">&nbsp;&nbsp;&nbsp;广播电视</option>
                                        <option value="通信">&nbsp;&nbsp;&nbsp;通信</option>
                                        <option value="金融">金融</option>
                                        <option value="银行">&nbsp;&nbsp;&nbsp;银行</option>
                                        <option value="资本投资">&nbsp;&nbsp;&nbsp;资本投资</option>
                                        <option value="证券投资">&nbsp;&nbsp;&nbsp;证券投资</option>
                                        <option value="保险">&nbsp;&nbsp;&nbsp;保险</option>
                                        <option value="信贷">&nbsp;&nbsp;&nbsp;信贷</option>
                                        <option value="财务">&nbsp;&nbsp;&nbsp;财务</option>
                                        <option value="审计">&nbsp;&nbsp;&nbsp;审计</option>
                                        <option value="服务业">服务业</option>
                                        <option value="法律">&nbsp;&nbsp;&nbsp;法律</option>
                                        <option value="餐饮">&nbsp;&nbsp;&nbsp;餐饮</option>
                                        <option value="酒店">&nbsp;&nbsp;&nbsp;酒店</option>
                                        <option value="旅游">&nbsp;&nbsp;&nbsp;旅游</option>
                                        <option value="广告">&nbsp;&nbsp;&nbsp;广告</option>
                                        <option value="公关">&nbsp;&nbsp;&nbsp;公关</option>
                                        <option value="景观">&nbsp;&nbsp;&nbsp;景观</option>
                                        <option value="咨询分析">&nbsp;&nbsp;&nbsp;咨询分析</option>
                                        <option value="市场推广">&nbsp;&nbsp;&nbsp;市场推广</option>
                                        <option value="人力资源">&nbsp;&nbsp;&nbsp;人力资源</option>
                                        <option value="社工服务">&nbsp;&nbsp;&nbsp;社工服务</option>
                                        <option value="养老服务">&nbsp;&nbsp;&nbsp;养老服务</option>
                                        <option value="教育">教育</option>
                                        <option value="高等教育">&nbsp;&nbsp;&nbsp;高等教育</option>
                                        <option value="基础教育">&nbsp;&nbsp;&nbsp;基础教育</option>
                                        <option value="职业教育">&nbsp;&nbsp;&nbsp;职业教育</option>
                                        <option value="幼儿教育">&nbsp;&nbsp;&nbsp;幼儿教育</option>
                                        <option value="特殊教育">&nbsp;&nbsp;&nbsp;特殊教育</option>
                                        <option value="培训">&nbsp;&nbsp;&nbsp;培训</option>
                                        <option value="医疗服务">医疗服务</option>
                                        <option value="临床医疗">&nbsp;&nbsp;&nbsp;临床医疗</option>
                                        <option value="制药">&nbsp;&nbsp;&nbsp;制药</option>
                                        <option value="保健">&nbsp;&nbsp;&nbsp;保健</option>
                                        <option value="美容">&nbsp;&nbsp;&nbsp;美容</option>
                                        <option value="医疗器材">&nbsp;&nbsp;&nbsp;医疗器材</option>
                                        <option value="生物工程">&nbsp;&nbsp;&nbsp;生物工程</option>
                                        <option value="疗养服务">&nbsp;&nbsp;&nbsp;疗养服务</option>
                                        <option value="护理服务">&nbsp;&nbsp;&nbsp;护理服务</option>
                                        <option value="艺术娱乐">艺术娱乐</option>
                                        <option value="创意艺术">&nbsp;&nbsp;&nbsp;创意艺术</option>
                                        <option value="体育健身">&nbsp;&nbsp;&nbsp;体育健身</option>
                                        <option value="娱乐休闲">&nbsp;&nbsp;&nbsp;娱乐休闲</option>
                                        <option value="图书馆">&nbsp;&nbsp;&nbsp;图书馆</option>
                                        <option value="博物馆">&nbsp;&nbsp;&nbsp;博物馆</option>
                                        <option value="策展">&nbsp;&nbsp;&nbsp;策展</option>
                                        <option value="博彩">&nbsp;&nbsp;&nbsp;博彩</option>
                                        <option value="制造加工">制造加工</option>
                                        <option value="食品饮料业">&nbsp;&nbsp;&nbsp;食品饮料业</option>
                                        <option value="纺织皮革业">&nbsp;&nbsp;&nbsp;纺织皮革业</option>
                                        <option value="服装业">&nbsp;&nbsp;&nbsp;服装业</option>
                                        <option value="烟草业">&nbsp;&nbsp;&nbsp;烟草业</option>
                                        <option value="造纸业">&nbsp;&nbsp;&nbsp;造纸业</option>
                                        <option value="印刷业">&nbsp;&nbsp;&nbsp;印刷业</option>
                                        <option value="化工业">&nbsp;&nbsp;&nbsp;化工业</option>
                                        <option value="汽车">&nbsp;&nbsp;&nbsp;汽车</option>
                                        <option value="家具">&nbsp;&nbsp;&nbsp;家具</option>
                                        <option value="电子电器">&nbsp;&nbsp;&nbsp;电子电器</option>
                                        <option value="机械设备">&nbsp;&nbsp;&nbsp;机械设备</option>
                                        <option value="塑料工业">&nbsp;&nbsp;&nbsp;塑料工业</option>
                                        <option value="金属加工">&nbsp;&nbsp;&nbsp;金属加工</option>
                                        <option value="军火">&nbsp;&nbsp;&nbsp;军火</option>
                                        <option value="地产建筑">地产建筑</option>
                                        <option value="房地产">&nbsp;&nbsp;&nbsp;房地产</option>
                                        <option value="装饰装潢">&nbsp;&nbsp;&nbsp;装饰装潢</option>
                                        <option value="物业服务">&nbsp;&nbsp;&nbsp;物业服务</option>
                                        <option value="特殊建造">&nbsp;&nbsp;&nbsp;特殊建造</option>
                                        <option value="建筑设备">&nbsp;&nbsp;&nbsp;建筑设备</option>
                                        <option value="贸易零售">贸易零售</option>
                                        <option value="零售">&nbsp;&nbsp;&nbsp;零售</option>
                                        <option value="大宗交易">&nbsp;&nbsp;&nbsp;大宗交易</option>
                                        <option value="进出口贸易">&nbsp;&nbsp;&nbsp;进出口贸易</option>
                                        <option value="公共服务">公共服务</option>
                                        <option value="政府">&nbsp;&nbsp;&nbsp;政府</option>
                                        <option value="国防军事">&nbsp;&nbsp;&nbsp;国防军事</option>
                                        <option value="航天">&nbsp;&nbsp;&nbsp;航天</option>
                                        <option value="科研">&nbsp;&nbsp;&nbsp;科研</option>
                                        <option value="给排水">&nbsp;&nbsp;&nbsp;给排水</option>
                                        <option value="水利能源">&nbsp;&nbsp;&nbsp;水利能源</option>
                                        <option value="电力电网">&nbsp;&nbsp;&nbsp;电力电网</option>
                                        <option value="公共管理">&nbsp;&nbsp;&nbsp;公共管理</option>
                                        <option value="环境保护">&nbsp;&nbsp;&nbsp;环境保护</option>
                                        <option value="非营利组织">&nbsp;&nbsp;&nbsp;非营利组织</option>
                                        <option value="开采冶金">开采冶金</option>
                                        <option value="煤炭工业">&nbsp;&nbsp;&nbsp;煤炭工业</option>
                                        <option value="石油工业">&nbsp;&nbsp;&nbsp;石油工业</option>
                                        <option value="黑色金属">&nbsp;&nbsp;&nbsp;黑色金属</option>
                                        <option value="有色金属">&nbsp;&nbsp;&nbsp;有色金属</option>
                                        <option value="土砂石开采">&nbsp;&nbsp;&nbsp;土砂石开采</option>
                                        <option value="地热开采">&nbsp;&nbsp;&nbsp;地热开采</option>
                                        <option value="交通仓储">交通仓储</option>
                                        <option value="邮政">&nbsp;&nbsp;&nbsp;邮政</option>
                                        <option value="物流递送">&nbsp;&nbsp;&nbsp;物流递送</option>
                                        <option value="地面运输">&nbsp;&nbsp;&nbsp;地面运输</option>
                                        <option value="铁路运输">&nbsp;&nbsp;&nbsp;铁路运输</option>
                                        <option value="管线运输">&nbsp;&nbsp;&nbsp;管线运输</option>
                                        <option value="航运业">&nbsp;&nbsp;&nbsp;航运业</option>
                                        <option value="民用航空业">&nbsp;&nbsp;&nbsp;民用航空业</option>
                                        <option value="农林牧渔">农林牧渔</option>
                                        <option value="种植业">&nbsp;&nbsp;&nbsp;种植业</option>
                                        <option value="畜牧养殖业">&nbsp;&nbsp;&nbsp;畜牧养殖业</option>
                                        <option value="林业">&nbsp;&nbsp;&nbsp;林业</option>
                                        <option value="渔业">&nbsp;&nbsp;&nbsp;渔业</option>

                                    </select>
                                </div>
                                <p class="wtdesc">行业信息会显示在你的个人页面</p>
                            </div>
                        </div>
                    </div>
                    <div class="wtzm-profile-module wtjvzhudi2">
                        <h3>居住地</h3>
                        <div class="wtzm-profile-module-desc">
                            <div class="wtzm-profile-edit-fieldset">
                                <span class="wttopic-input-wrap">
                                    <input autocomplete="off" name="wth-jv" aria-haspopup="true" type="text" class="wttianjiajvzhudi wtzg-form-text-input" placeholder="添加居住地" value="<%=address %>" aria-label="添加居住地" />
                                </span>
                            </div>
                        </div>
                    </div>
                    <div class="wtzm-profile-module wtzm-profile-details-editform-career">
                        <h3>职业经历</h3>
                        <div class="wtzm-profile-module-desc">
                            <div class="wtzm-profile-edit-fieldset">
                                <p>
                                    <span class="wttopic-input-wrap">
                                        <input name="wth-company" autocomplete="off" aria-haspopup="true" type="text" class="wtzg-form-text-input wtgsname" placeholder="公司或组织名称" value="<%=company %>" aria-label="公司或组织名称" />
                                    </span>
                                    <span class="wttopic-input-wrap wtzhiwei">
                                        <input name="wth-position" autocomplete="off" aria-haspopup="true" type="text" class="wtzg-form-text-input wtgsname" placeholder="你的职位（选填）" value="<%=position %>" aria-label="你的职位（选填）" />
                                    </span>

                                </p>

                            </div>
                        </div>
                    </div>
                    <div class="wtzm-profile-module wtzm-profile-details-editform-career">
                        <h3>教育经历</h3>
                        <div class="wtzm-profile-module-desc">
                            <div class="wtzm-profile-edit-fieldset">
                                <p>
                                    <span class="wttopic-input-wrap">
                                        <input id="wtinputschool" name="wtinputschool" autocomplete="off" aria-haspopup="true" type="text" class="wtzg-form-text-input wtgsname" placeholder="学校或教育机构名" value="<%=academy %>" aria-label="学校或教育机构名" />

                                    </span>
                                    <span class="wttopic-input-wrap wtzhiwei">
                                        <input name="wth-major" autocomplete="off" aria-haspopup="true" type="text" class="wtzg-form-text-input wtgsname" placeholder="专业方向（选填）" value="<%=major %>" aria-label="专业方向（选填）" />
                                    </span>

                                </p>

                            </div>
                        </div>
                    </div>
                    <div class="wtzm-profile-module wtzm-profile-details-editform-gender">
                        <h3>擅长话题</h3>
                        <div class="wtzm-profile-module-desc2">
                            <label>
                                <input type="radio" name="openclose" value="1" class="open" />
                                开启&nbsp;&nbsp;
                            </label>
                            <label>
                                <input type="radio" name="openclose" value="0" class="close" checked="checked" />
                                关闭
                            </label>

                        </div>
                    </div>
                    <div class="wtzm-profile-module wtzm-profile-details-editform-footer">
                        <p>
                            <asp:Button ID="wtbuttonlast" class="wtzg-btn-blue" runat="server" Text="保存设置" OnClick="wtbuttonlast_Click" />
                            <a class="wtzg-gray-normal">取消修改</a>
                        </p>
                    </div>
                </div>
            </div>
        </div>

        <div class="wtzu-main-sidebar">
            <div class="wtzm-profile-side-following wtzg-clear">
                <a class="wtfoitem">
                    <span class="wtzg-gray-normal">关注了</span>
                    <br />
                    <strong>0</strong>
                    <label>人</label>
                </a>
                <a class="wtfoitem wtleftborder">
                    <span class="wtzg-gray-normal">关注了</span>
                    <br />
                    <strong>0</strong>
                    <label>人</label>
                </a>
            </div>
             
            <div class="wtzm-profile-side-section">
                <div class="wtzm-profile-side-section-title">
                    <span>关注了</span>
                    <a class="wtzg-link-litblue">
                        <span>2 个话题</span>
                    </a>
                </div>
                <asp:Repeater runat="server" ID="Repeater2">
                        <ItemTemplate>
                <%--<div class="wtzm-profile-side-topics">
                    <a class="wtlink">
                        <img src="http://pic4.zhimg.com/fb89e0ea3_m.jpg" class="wtavatar2" />
                    </a>
                </div>--%>
                <div class="wtzm-profile-side-topics">
                    <a class="wtlink">
                        <img src="<%#Eval("topicPicUrl") %>" class="wtavatar2" />
                    </a>
                </div>
                            
                         </ItemTemplate>
                </asp:Repeater>
            </div>
            <div class="wtzm-profile-side-section2">
                <div class="wtzm-side-section-inner">
                    <span class="wtzg-gray-normal">个人主页被
						<strong>2</strong>
                        人浏览
                    </span>
                </div>
            </div>
            <div class="wtzh-footer">
                <div class="wtzg-wrap2">
                    <ul>
                        <li>
                            <a href="#">知乎指南</a>
                        </li>
                        <li>
                            <a href="#">建议反馈</a>
                        </li>
                        <li>
                            <a href="#">移动应用</a>
                        </li>
                        <li>
                            <a href="#">知乎阅读</a>
                        </li>
                        <br />
                        <li>
                            <a href="#">加入知乎</a>
                        </li>
                        <li>
                            <a href="#">知乎协议</a>
                        </li>
                        <li>
                            <a href="#">商务合作</a>
                        </li>
                    </ul>
                    <span class="wtcopy">© 2014 知乎</span>
                </div>
            </div>

        </div>
        <div class="clear"></div>
    </div>

</asp:Content>
