<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="executePaymentWebForm.aspx.cs" Inherits="MerchantWebApplication.PayPalPmtMng.executePaymentWebForm" %>

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
	<title>PayPal Web Services</title>
</head>
<body>
	<div id="content">
		<p class="heading1">PayPal Web Services</p>
		<br />
		<form id="form1" runat="server">
			<div>
				<p class="intro">Click <a href="../MerchantDefaultWebForm.aspx">here</a> for a complete list of operations.</p>
				<h2>executePayment</h2>
				<p class="intro"></p>

				<h3>Request</h3>
				To test the operation using the HTTP POST protocol, click the 'Invoke' button.
				<div>
					<table>
						<tr>
							<td class="auto-style3">User Name:</td>
							<td>
								<asp:TextBox ID="Input_userName" runat="server" Width="300px">user</asp:TextBox>
							</td>
						</tr>
						<tr>
							<td class="auto-style3">Password:</td>
							<td>
								<asp:TextBox ID="Input_password" runat="server" Width="300px">21bd12dc183f740ee76f27b78eb39c8ad972a757</asp:TextBox>
							</td>
						</tr>
						<tr>
							<td class="auto-style3">Testing URL:</td>
							<td>
								<asp:TextBox ID="Input_testingURL" runat="server" Width="300px">http://41.33.202.181:80/PS/PayPalPmtMng</asp:TextBox>
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
							<asp:TextBox ID="Input_RqUID" runat="server" Width="300px">ppExecutePmt</asp:TextBox>
						</td>
					</tr>
					<tr>
						<td class="auto-style3">Profile Code:</td>
						<td>
							<asp:TextBox ID="Input_ProfileCD" runat="server" Width="300px">00026</asp:TextBox>
						</td>
					</tr>
					<tr>
						<td class="auto-style3">Merchant Transactions Reference:</td>
						<td>
							<asp:TextBox ID="Input_MerchTrnsRef" runat="server" Width="300px">4567</asp:TextBox>
						</td>
					</tr>
					<tr>
						<td class="auto-style3">Acquire Transactions Reference:</td>
						<td>
							<asp:TextBox ID="Input_AcquireTrnsRef" runat="server" Width="300px">PAY-5DW47345JT879115ULLVZCAI</asp:TextBox>
						</td>
					</tr>
					<tr>
						<td class="auto-style3">Acquire Receipt Reference:</td>
						<td>
							<asp:TextBox ID="Input_AcquireReceiptRef" runat="server" Width="300px">EC-14018948WH0323902</asp:TextBox>
						</td>
					</tr>
					<tr>
						<td class="auto-style3">Payer ID:</td>
						<td>
							<asp:TextBox ID="Input_PayerID" runat="server" Width="300px">59QHSMZ87Z7EC</asp:TextBox>
						</td>
					</tr>
					<tr>
						<td class="auto-style3">Invoice Number:</td>
						<td>
							<asp:TextBox ID="Input_InvoiceNo" runat="server" Width="300px"></asp:TextBox>
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
						<td class="auto-style4">Transaction Amount:</td>
						<td class="auto-style4">
							<asp:Label ID="Label4" runat="server" ForeColor="Blue"></asp:Label>
						</td>
					</tr>
					<tr>
						<td class="auto-style4">Acquire Transaction Reference:</td>
						<td class="auto-style4">
							<asp:Label ID="Label5" runat="server" ForeColor="Blue"></asp:Label>
						</td>
					</tr>
					<tr>
						<td class="auto-style4">Acquire Message:</td>
						<td class="auto-style4">
							<asp:Label ID="Label6" runat="server" ForeColor="Blue"></asp:Label>
						</td>
					</tr>
					<tr>
						<td class="auto-style4">Acquire Debug ID:</td>
						<td class="auto-style4">
							<asp:Label ID="Label7" runat="server" ForeColor="Blue"></asp:Label>
						</td>
					</tr>
					<tr>
						<td class="auto-style1">Billing Response Info.</td>
					</tr>
					<tr>
						<td class="auto-style4">Invoice Number:</td>
						<td class="auto-style4">
							<asp:Label ID="Label8" runat="server" ForeColor="Blue"></asp:Label>
						</td>
					</tr>
					<tr>
						<td class="auto-style4">Is Invoice Finalized:</td>
						<td class="auto-style4">
							<asp:Label ID="Label9" runat="server" ForeColor="Blue"></asp:Label>
						</td>
					</tr>
				</table>
		</div>
	</div>
</body>
</html>
