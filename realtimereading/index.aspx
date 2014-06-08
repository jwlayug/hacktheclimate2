<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="realtimereading.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="resources/css/bootstrap.min.css" rel="stylesheet" />
    <link href="resources/css/dashboard.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <nav class="navbar navbar-fixed-top" role="navigation" style="background-color:#75b08a; color:#fff">
          <div class="container-fluid">
            <!-- Brand and toggle get grouped for better mobile display -->
            <div class="navbar-header">
              <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                <span class="sr-only">Toggle navigation</span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
              </button>
              <a class="navbar-brand" href="#" style="color:#fff">Brand</a>
            </div>

            <!-- Collect the nav links, forms, and other content for toggling -->
            <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
              <ul class="nav navbar-nav">
                <li class="active"><a href="#" style="color:#fff">Link</a></li>
                <li><a href="#" style="color:#fff">Link</a></li>
              </ul>
             
            </div><!-- /.navbar-collapse -->
          </div><!-- /.container-fluid -->
        </nav>
        <div class="col-md-12 today">
      

            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <%--<asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick"></asp:Timer>--%>
            <asp:Timer ID="Timer2" runat="server" Interval="5000" OnTick="Timer2_Tick"></asp:Timer>
            <asp:Timer ID="Timer3" runat="server" OnTick="Timer3_Tick"></asp:Timer>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>

                    <div class="container-fluid">
      <div class="row">
        
        <div class="col-sm-9 col-sm-offset-3 col-md-10 col-md-offset-2 main">
          <h1 class="page-header">Dashboard</h1>

          <div class="row placeholders">
            <div class="col-xs-6 col-sm-3 placeholder">
        
        
              <h4>Label</h4>
              <span class="text-muted">
                    <asp:Label ID="lblReading" runat="server" Text="Label"></asp:Label>
                    <asp:Label ID="lblDesc" runat="server" Text="Label"></asp:Label>
              </span>
            </div>
            <div class="col-xs-6 col-sm-3 placeholder">
        
              <h4>Label</h4>
              <span class="text-muted">
                  <asp:Label class="day" ID="lblDay" runat="server"></asp:Label>
                    <asp:Label class="date" ID="lblDate" runat="server"></asp:Label>
                    <asp:Label class="time" ID="lblTime" runat="server"></asp:Label>

              </span>
            </div>
            <div class="col-xs-6 col-sm-3 placeholder">
        
              <h4>Label</h4>
              <span class="text-muted"><asp:Label ID="lblTemp" runat="server" server="labal"></asp:Label></span>
            </div>
            <div class="col-xs-6 col-sm-3 placeholder">
        
              <h4>Label</h4>
              <span class="text-muted">Something else</span>
            </div>
          </div>

          
          
        </div>
      </div>
    </div>


                  <%--  <div class="container">
                    <div class="col-md-4" style="text-align:center;background-color:#33475E; padding:10px;color:#fff;">--%>
                    
                    <%--</div>--%>

                    <%--<div class="col-md-4" style="text-align:center;background-color:#75b08a; padding:100px;color:#fff;margin-top:50px;border-radius:100%;">--%>
                            
                    <%--</div>              --%>

                    <%--<div class="col-md-4" style="text-align:center;background-color:#ff5460; padding:10px;color:#fff;">--%>
                        
                   <%-- </div>--%>              
                    </div>
                    
                    
                    
                </ContentTemplate>
                <Triggers>
                    <%--<asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick"></asp:AsyncPostBackTrigger>--%>
                    <asp:AsyncPostBackTrigger ControlID="Timer2" EventName="Tick"></asp:AsyncPostBackTrigger>
                </Triggers>
            </asp:UpdatePanel>
        </div>

        
    </form>
    <script src="resources/js/jquery-1.11.1.min.js"></script>
    <script src="resources/js/bootstrap.min.js"></script>
</body>
</html>
