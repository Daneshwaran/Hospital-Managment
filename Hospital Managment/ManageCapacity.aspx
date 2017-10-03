<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageCapacity.aspx.cs" Inherits="Hospital_Managment.ManageCapacity"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta/css/bootstrap.min.css" integrity="sha384-/Y6pD6FV/Vv2HJnA6t+vslU6fwYXjCFtcEpHbNJ0lyAFsXTsjBbfaDjzALeQsN6M" crossorigin="anonymous"/>
   <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.11.0/umd/popper.min.js" integrity="sha384-b/U6ypiBEHpOf/4+1nzFpr53nxSS+GLCkfwBdFNTxtclqqenISfwAzpKaMNFNmj4" crossorigin="anonymous"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta/js/bootstrap.min.js" integrity="sha384-h0AbiXch4ZDo7tp9hKZ4TsHbi047NrKGLO3SEJAg45jXxnGIfYzk4Si90RDIqNm1" crossorigin="anonymous"></script>
    
    <style type="text/css">
        .auto-style1 {
            position: relative;
            width: 100%;
            min-height: 1px;
            -ms-flex-preferred-size: 0;
            flex-basis: 0;
            -ms-flex-positive: 1;
            flex-grow: 1;
            max-width: 100%;
            left: -1px;
            top: 1px;
            padding-left: 15px;
            padding-right: 15px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">



    <div class="jumbotron jumbotron-fluid">
  <div class="container">
    <h1 class="display-3">Hospital Capacity Management</h1>




      <div class="alert alert-primary" role="alert">
     <p class="lead">Current Admission Status</p>
     <div class="container">
<div class="progress">
  <div class="progress-bar progress-bar-striped progress-bar-animated" role="progressbar" aria-valuenow= 75 aria-valuemin="0" aria-valuemax="100" style="width: 75%"></div>
</div>
</div>
</div>


 </div>
</div>
    <ul class="nav nav-pills" id="myTab" role="tablist">
  <li class="nav-item">
    <a class="nav-link active" id="analysis-tab" data-toggle="tab" href="#analysis" role="tab" aria-controls="home" aria-expanded="true">ANALYSIS</a>
  </li>
  <li class="nav-item">
    <a class="nav-link" id="admittedpatients-tab" data-toggle="tab" href="#admittedpatients" role="tab" aria-controls="profile">ADMITTED PATIENTS</a>
  </li>
        
  <li class="nav-item">
    <a class="nav-link" id="createadmission-tab" data-toggle="tab" href="#createadmission" role="tab" aria-controls="profile">DISCHARGED PATIENTS</a>
  </li>
         
  <li class="nav-item">
    <a class="nav-link" id="dischargedpatients-tab" data-toggle="tab" href="#dischargedpatients" role="tab" aria-controls="profile">CREATE ADMISSION</a>
  </li>
</ul>






<div class="tab-content" id="myTabContent">
  <div class="tab-pane fade show active" id="home" role="tabpanel" aria-labelledby="analysis-tab">

        <div class="card-deck">
  <div class="card">
      <div class="container">
         <canvas id="lineChart" width="400" height="400"></canvas>
            </div>

    <div class="card-body">
      <h4 class="card-title">Admitted Patients</h4>
      <p class="card-text">This is a plot of Number of patients admitted for past six weeks</p>
    </div>
    <div class="card-footer">
      <small class="text-muted">updated just now</small>
    </div>
  </div>
  <div class="card">
   <div class="container">
         <canvas id="lineChart1" width="400" height="400"></canvas>
            </div>

    <div class="card-body">
      <h4 class="card-title">Discharged patients</h4>
      <p class="card-text">This is a plot of Number of patients discharged for past six weeks</p>
    </div>
    <div class="card-footer">
      <small class="text-muted">updated just now</small>
    </div>
  </div>
  <div class="card">
    
        <div class="container">
         <canvas id="lineChart2" width="400" height="400"></canvas>
            </div>
    <div class="card-body">
      <h4 class="card-title">Availabilty</h4>
      <p class="card-text"></p>
    </div>
    <div class="card-footer">
      <small class="text-muted">updated just now</small>
    </div>
  </div>
</div>














  </div>
  <div class="tab-pane fade" id="admittedpatients" role="tabpanel" aria-labelledby="admittedpatients-tab">


      
        <div>
            <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                    <table class="table table-hover" aria-setsize="50"/>
                        <tr>
                            <th>AdmitId</th>
                            <th>HospitalId</th>
                            <th>DoctorId</th>
                            <th>AdmitDate</th>
                             <th>WardNumber</th>
                        </tr>
                       </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr >
                        <td>
                            <asp:Label runat="server" Text='<% # Eval("AdmitId") %>' /></td>
                            <td><asp:Label runat="server" Text='<% # Eval("HospitalId") %>' /></td>
                            <td><asp:Label runat="server" Text='<% # Eval("DoctorId") %>' /></td>
                        <td><asp:Label runat="server" Text='<% # Eval("AdmitDate") %>' /></td>
                        <td><asp:Label runat="server" Text='<% # Eval("WardNumber") %>' /></td>
                        
                        </tr>
                        
                    </tr>
                </ItemTemplate>
              
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
            </div>














  </div>
  <div class="tab-pane fade" id="createadmission" role="tabpanel" aria-labelledby="createadmission-tab">





       <asp:Repeater ID="Repeater2" runat="server">
                 <HeaderTemplate>
                    <table class="table table-hover" aria-setsize="50"/>
                        <tr>
                            <th>DischargeId</th>
                            <th>HospitalId</th>
                            <th>WardNumber</th>
                            <th>AdmitDate</th>
                             <th>Doctor</th>
                            <th>DischargeDate</th>
                        </tr>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr >
                        <td>
                            <asp:Label runat="server" Text='<% # Eval("DischargeId") %>' /></td>
                            <td><asp:Label runat="server" Text='<% # Eval("HospitalId") %>' /></td>
                            <td><asp:Label runat="server" Text='<% # Eval("WardNumber") %>' /></td>
                        <td><asp:Label runat="server" Text='<% # Eval("AdmitDate") %>' /></td>
                        <td><asp:Label runat="server" Text='<% # Eval("DoctorId") %>' /></td>
                        <td><asp:Label runat="server" Text='<% # Eval("DischargeDate") %>' /></td>
                        
                        </tr>
                        
                    </tr>
                </ItemTemplate>
              
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>

  </div>
  <div class="tab-pane fade" id="dischargedpatients" role="tabpanel" aria-labelledby="dischargedpatients-tab">
              <div class="container">
       
  <div class="row">
    <div class="col">
      <asp:textbox runat="server" type="text" class="form-control" placeholder="Hospital ID"/>
    </div>
    <div class="col">
      <asp:textbox runat="server" type="text" class="form-control" placeholder="Doctor ID"/>
    </div>
  </div>
        <br /> 
  <div class="row">
    <div class="col">
      <asp:textbox runat="server" type="text" class="form-control" placeholder="Admit Date"/>
    </div>
    <div class="auto-style1">
      <asp:textbox runat="server" type="text" class="form-control" placeholder="Ward Number"/>
    </div>
  </div>
            <br />
<asp:button runat="server" type="button" class="btn btn-outline-primary btn-lg btn-block" Text="Admit Patient" ></asp:button>
            </div>


  </div>

 
       <script src="Scripts/Chart.js"></script>  
    <script src="Scripts/main.js"></script>


    </form>
</body>
</html>
