<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pmtUploadWebForm.aspx.cs" Inherits="MerchantWebApplication.SADADPmtMng.pmtUploadWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
	<style type="text/css">
		BODY {
			color: #000000;
			background-color: white;
			font-family: Verdana;
			margin-left: 0px;
			margin-top: 0px;
		}

		#content {
			margin-left: 30px;
			font-size: .70em;
			padding-bottom: 2em;
		}

		A:link {
			color: #336699;
			font-weight: bold;
			text-decoration: underline;
		}

		A:visited {
			color: #6699cc;
			font-weight: bold;
			text-decoration: underline;
		}

		A:active {
			color: #336699;
			font-weight: bold;
			text-decoration: underline;
		}

		A:hover {
			color: #cc3300;
			font-weight: bold;
			text-decoration: underline;
		}

		P {
			color: #000000;
			margin-top: 0px;
			margin-bottom: 12px;
			font-family: Verdana;
		}

		pre {
			background-color: #e5e5cc;
			padding: 5px;
			font-family: Courier New;
			font-size: x-small;
			margin-top: -5px;
			border: 1px #f0f0e0 solid;
		}

		td {
			color: #000000;
			font-family: Verdana;
			font-size: .7em;
		}

		h2 {
			font-size: 1.5em;
			font-weight: bold;
			margin-top: 25px;
			margin-bottom: 10px;
			border-top: 1px solid #003366;
			margin-left: -15px;
			color: #003366;
		}

		h3 {
			font-size: 1.1em;
			color: #000000;
			margin-left: -15px;
			margin-top: 10px;
			margin-bottom: 10px;
		}

		ul {
			margin-top: 10px;
			margin-left: 20px;
		}

		ol {
			margin-top: 10px;
			margin-left: 20px;
		}

		li {
			margin-top: 10px;
			color: #000000;
		}

		font.value {
			color: darkblue;
			font: bold;
		}

		font.key {
			color: darkgreen;
			font: bold;
		}

		font.error {
			color: darkred;
			font: bold;
		}

		.heading1 {
			color: #ffffff;
			font-family: Tahoma;
			font-size: 26px;
			font-weight: normal;
			background-color: #003366;
			margin-top: 0px;
			margin-bottom: 0px;
			margin-left: -30px;
			padding-top: 10px;
			padding-bottom: 3px;
			padding-left: 15px;
			width: 105%;
		}

		.button {
			background-color: #dcdcdc;
			font-family: Verdana;
			font-size: 1em;
			border-top: #cccccc 1px solid;
			border-bottom: #666666 1px solid;
			border-left: #cccccc 1px solid;
			border-right: #666666 1px solid;
		}

		.frmheader {
			color: #000000;
			background: #dcdcdc;
			font-family: Verdana;
			font-size: .7em;
			font-weight: normal;
			border-bottom: 1px solid #dcdcdc;
			padding-top: 2px;
			padding-bottom: 2px;
		}

		.frmtext {
			font-family: Verdana;
			font-size: .7em;
			margin-top: 8px;
			margin-bottom: 0px;
			margin-left: 32px;
		}

		.frmInput {
			font-family: Verdana;
			font-size: 1em;
		}

		.intro {
			margin-left: -15px;
		}

		#cssTable {
			border-spacing: 0px;
			border: 1px solid gray;
			padding: 4px;
			border-color: #dcdcdc;
			border-collapse: collapse;
			text-align: center;
			vertical-align: middle;
		}

		.auto-style1 {
			font-size: small;
			background-color: #C0C0C0;
		}

		.auto-style3 {
			font-size: small;
		}

		.auto-style4 {
			font-size: small;
			height: 20px;
		}
	</style>
	<title>SADAD Web Services</title>
</head>
<body>
	<div id="content">
		<p class="heading1">SADAD Web Services</p>
		<br />
		<form id="form1" runat="server">
			<div>
				<p class="intro">Click <a href="../MerchantDefaultWebForm.aspx">here</a> for a complete list of operations.</p>
				<h2>pmtUpload</h2>
				<p class="intro"></p>

				<h3>Request</h3>
				To test the operation using the HTTP POST protocol, click the 'Invoke' button.
				<div>
					<table>
						<tr>
							<td class="auto-style3">User Name:</td>
							<td>
								<asp:TextBox ID="Input_userName" runat="server" Width="300px"></asp:TextBox>
							</td>
						</tr>
						<tr>
							<td class="auto-style3">Password:</td>
							<td>
								<asp:TextBox ID="Input_password" runat="server" Width="300px" TextMode="Password"></asp:TextBox>
							</td>
						</tr>
						<tr>
							<td class="auto-style3">Testing URL:</td>
							<td>
								<asp:TextBox ID="Input_testingURL" runat="server" Width="300px"></asp:TextBox>
							</td>
						</tr>
						<tr>
							<td class="auto-style3">Production URL:</td>
							<td>
								<asp:TextBox ID="Input_productionURL" runat="server" Width="300px"></asp:TextBox>
							</td>
						</tr>
						<tr>
							<td class="auto-style3">Application Mode:</td>
							<td>
								
								<asp:DropDownList ID="DropDownList1" runat="server">
									<asp:ListItem Selected="True">Test</asp:ListItem>
									<asp:ListItem>Production</asp:ListItem>
								</asp:DropDownList>
								
							</td>
						</tr>
						<tr>
							<td class="auto-style3">On-Premsis:</td>
							<td>
								
								<asp:DropDownList ID="DropDownList2" runat="server">
									<asp:ListItem>Yes</asp:ListItem>
									<asp:ListItem>No</asp:ListItem>
								</asp:DropDownList>
								
							</td>
						</tr>
					</table>
				</div>
				<table>
					<tr>
						<td class="auto-style1">Parameter</td>
						<td class="auto-style1">Value</td>
					</tr>
					<tr>
						<td class="auto-style3">RqUID:</td>
						<td>
							<asp:TextBox ID="Input_RqUID" runat="server" Width="300px">pmtUpload</asp:TextBox>
						</td>
					</tr>
					<tr>
						<td class="auto-style3">Profile Code:</td>
						<td>
							<asp:TextBox ID="Input_ProfileCD" runat="server" Width="300px">00026</asp:TextBox>
						</td>
					</tr>
					<tr>
						<td class="auto-style3">Invoice Number:</td>
						<td>
							<asp:TextBox ID="Input_InvoiceNo" runat="server" Width="300px">12345-HKKHH-WW</asp:TextBox>
						</td>
					</tr>
					<tr>
						<td class="auto-style3">Merchant Transactions Reference:</td>
						<td>
							<asp:TextBox ID="Input_MerchTrnsRef" runat="server" Width="300px">102</asp:TextBox>
						</td>
					</tr>
					<tr>
						<td class="auto-style3">Acquire Transactions Reference:</td>
						<td>
							<asp:TextBox ID="Input_AcquireTrnsRef" runat="server" Width="300px">34525</asp:TextBox>
						</td>
					</tr>
					<tr>
						<td class="auto-style3">Invoice Cycle:</td>
						<td>
							<asp:TextBox ID="Input_InvoiceCycle" runat="server" Width="300px">01 2020 JED</asp:TextBox>
						</td>
					</tr>
					<tr>
						<td class="auto-style3">Billing Account:</td>
						<td>
							<asp:TextBox ID="Input_BillingAcct" runat="server" Width="300px">1234</asp:TextBox>
						</td>
					</tr>
					<tr>
						<td class="auto-style3">Transaction Amount:</td>
						<td>
							<asp:TextBox ID="Input_TrnsAmount" runat="server" Width="300px">123</asp:TextBox>
						</td>
					</tr>
					<tr>
						<td class="auto-style3">Process Date:</td>
						<td>
							<asp:TextBox ID="Input_PrcDt" runat="server" Width="300px">2018-01-06T13:26:59+03:00</asp:TextBox>
						</td>
					</tr>
					<tr>
						<td class="auto-style3">Payment Reference Info:</td>
						<td>
							<asp:TextBox ID="Input_PmtRefInfo" runat="server" Width="300px">payment infomation</asp:TextBox>
						</td>
					</tr>
					<tr>
						<td class="auto-style3">Customer ID Number:</td>
						<td>
							<asp:TextBox ID="Input_CustomerIDNo" runat="server" Width="300px">133</asp:TextBox>
						</td>
					</tr>
					<tr>
						<td class="auto-style3">Customer ID Type Code:</td>
						<td>
							<asp:TextBox ID="Input_CustomerIDTypeCD" runat="server" Width="300px">1</asp:TextBox>
						</td>
					</tr>
					<tr>
						<td class="auto-style3">Bank Code:</td>
						<td>
							<asp:TextBox ID="Input_BankCD" runat="server" Width="300px">RJHISARI</asp:TextBox>
						</td>
					</tr>
					<tr>
						<td class="auto-style3">Bank Branch Number:</td>
						<td>
							<asp:TextBox ID="Input_BankBranchNo" runat="server" Width="300px">90</asp:TextBox>
						</td>
					</tr>
					<tr>
						<td class="auto-style3">Payment Access Channel:</td>
						<td>
							<asp:TextBox ID="Input_PmtAccessChannel" runat="server" Width="300px">ATM</asp:TextBox>
						</td>
					</tr>
					<tr>
						<td class="auto-style3">District:</td>
						<td>
							<asp:TextBox ID="Input_District" runat="server" Width="300px">100</asp:TextBox>
						</td>
					</tr>
					<tr>
						<td class="auto-style3">Payment Method Code:</td>
						<td>
							<asp:TextBox ID="Input_PmtMthdCD" runat="server" Width="300px">CHECK</asp:TextBox>
						</td>
					</tr>
					<tr>
						<td></td>
						<td style="text-align: right;">
							<asp:Button ID="InvokeRequest_Button" runat="server" Text="Invoke" OnClick="InvokeRequest_Button_Click" />
						</td>
					</tr>
				</table>
			</div>
		</form>
		<div id="div1" runat="server" visible="false">
            <h3>Response</h3>
            The following is the response result for the test.
				<table>
					<tr>
						<td class="auto-style1">Parameter</td>
						<td class="auto-style1">Value</td>
					</tr>
					<tr>
						<td class="auto-style4">RqUID:</td>
						<td class="auto-style4">
							<asp:Label ID="Label1" runat="server" Text="Label1" ForeColor="Blue"></asp:Label>
						</td>
					</tr>
					<tr>
						<td class="auto-style4">Status Code:</td>
						<td class="auto-style4">
							<asp:Label ID="Label2" runat="server" Text="Label2" ForeColor="Blue"></asp:Label>
						</td>
					</tr>
					<tr>
						<td class="auto-style4">Transaction ID:</td>
						<td class="auto-style4">
							<asp:Label ID="Label3" runat="server" ForeColor="Blue"></asp:Label>
						</td>
					</tr>
					<tr>
						<td class="auto-style4">Is Bill Uploaded Successfully to SADAD:</td>
						<td class="auto-style4">
							<asp:Label ID="Label4" runat="server" ForeColor="Blue"></asp:Label>
						</td>
					</tr>
					<tr>
						<td class="auto-style1">Billing Response Info.</td>
					</tr>
					<tr>
						<td class="auto-style4">Invoice Number:</td>
						<td class="auto-style4">
							<asp:Label ID="Label5" runat="server" ForeColor="Blue"></asp:Label>
						</td>
					</tr>
					<tr>
						<td class="auto-style4">Is Invoice Finalized:</td>
						<td class="auto-style4">
							<asp:Label ID="Label6" runat="server" ForeColor="Blue"></asp:Label>
						</td>
					</tr>
				</table>
		</div>
	</div>
</body>
</html>
