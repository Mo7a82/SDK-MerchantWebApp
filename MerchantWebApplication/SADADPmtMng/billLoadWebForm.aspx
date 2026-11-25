<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="billLoadWebForm.aspx.cs" Inherits="MerchantWebApplication.SADADPmtMng.billLoadWebForm" %>

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
				<h2>billLoad</h2>
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
								<asp:TextBox ID="Input_testingURL" runat="server" Width="300px">http://41.33.202.181:80/PS/SADADPmtMng</asp:TextBox>
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
					<asp:Table runat="server">
						<asp:TableRow runat="server">
							<asp:TableCell>
								<asp:Table ID="RequestInputTable1" runat="server">
									<asp:TableRow runat="server">
										<asp:TableCell>
											<asp:Table runat="server">
												<asp:TableHeaderRow runat="server">
													<asp:TableHeaderCell class="auto-style1" Width="300px">Parameter</asp:TableHeaderCell>
													<asp:TableHeaderCell class="auto-style1">Value</asp:TableHeaderCell>
												</asp:TableHeaderRow>
												<asp:TableRow runat="server">
													<asp:TableCell class="auto-style3">RqUID:</asp:TableCell>
													<asp:TableCell class="auto-style3">
														<asp:TextBox ID="Input_RqUID" runat="server" Width="300px">testBillUploadTat</asp:TextBox>
													</asp:TableCell>
												</asp:TableRow>
												<asp:TableRow runat="server">
													<asp:TableCell class="auto-style3">Profile Code:</asp:TableCell>
													<asp:TableCell class="auto-style3">
														<asp:TextBox ID="Input_ProfileCD" runat="server" Width="300px">00026</asp:TextBox>
													</asp:TableCell>
												</asp:TableRow>
												<asp:TableRow runat="server">
													<asp:TableCell class="auto-style3">Customer Name:</asp:TableCell>
													<asp:TableCell class="auto-style3">
														<asp:TextBox ID="Input_CustomerName" runat="server" Width="300px">some customer name</asp:TextBox>
													</asp:TableCell>
												</asp:TableRow>
												<asp:TableRow runat="server">
													<asp:TableCell class="auto-style3">Merchant Transactions Reference:</asp:TableCell>
													<asp:TableCell class="auto-style3">
														<asp:TextBox ID="Input_MerchTrnsRef" runat="server" Width="300px">13455</asp:TextBox>
													</asp:TableCell>
												</asp:TableRow>
												<asp:TableRow runat="server">
													<asp:TableCell class="auto-style3">Merchant Order Info.:</asp:TableCell>
													<asp:TableCell class="auto-style3">
														<asp:TextBox ID="Input_MerchOrderInfo" runat="server" Width="300px">SADAD Bill Upload test</asp:TextBox>
													</asp:TableCell>
												</asp:TableRow>
												<asp:TableRow runat="server">
													<asp:TableCell class="auto-style3">Merchant Order Alias:</asp:TableCell>
													<asp:TableCell class="auto-style3">
														<asp:TextBox ID="Input_MerchOrderAlias" runat="server" Width="300px">SADAD Test</asp:TextBox>
													</asp:TableCell>
												</asp:TableRow>
												<asp:TableRow runat="server">
													<asp:TableCell class="auto-style3">Is Partial Payment:</asp:TableCell>
													<asp:TableCell class="auto-style3">
														<asp:TextBox ID="Input_IsPartialPayment" runat="server" Width="300px">N</asp:TextBox>
													</asp:TableCell>
												</asp:TableRow>
												<asp:TableRow runat="server">
													<asp:TableCell class="auto-style3">Language Code:</asp:TableCell>
													<asp:TableCell class="auto-style3">
														<asp:TextBox ID="Input_LangCD" runat="server" Width="300px">En</asp:TextBox>
													</asp:TableCell>
												</asp:TableRow>
												<asp:TableRow runat="server">
													<asp:TableCell class="auto-style3">Due Amount:</asp:TableCell>
													<asp:TableCell class="auto-style3">
														<asp:TextBox ID="Input_DueAmount" runat="server" Width="300px">100</asp:TextBox>
													</asp:TableCell>
												</asp:TableRow>
												<asp:TableRow runat="server">
													<asp:TableCell class="auto-style3">Maximum Amount:</asp:TableCell>
													<asp:TableCell class="auto-style3">
														<asp:TextBox ID="Input_MaxAmount" runat="server" Width="300px"></asp:TextBox>
													</asp:TableCell>
												</asp:TableRow>
												<asp:TableRow runat="server">
													<asp:TableCell class="auto-style3">Minimum Amount:</asp:TableCell>
													<asp:TableCell class="auto-style3">
														<asp:TextBox ID="Input_MinAmount" runat="server" Width="300px"></asp:TextBox>
													</asp:TableCell>
												</asp:TableRow>
												<asp:TableRow runat="server">
													<asp:TableCell class="auto-style3">Invoice Number:</asp:TableCell>
													<asp:TableCell class="auto-style3">
														<asp:TextBox ID="Input_InvoiceNo" runat="server" Width="300px">14774797</asp:TextBox>
													</asp:TableCell>
												</asp:TableRow>
												<asp:TableRow runat="server">
													<asp:TableCell class="auto-style3">Invoice Reference Info.:</asp:TableCell>
													<asp:TableCell class="auto-style3">
														<asp:TextBox ID="Input_InvoiceRefInfo" runat="server" Width="300px">invoice reference info</asp:TextBox>
													</asp:TableCell>
												</asp:TableRow>
												<asp:TableRow runat="server">
													<asp:TableCell class="auto-style3">Due Date:</asp:TableCell>
													<asp:TableCell class="auto-style3">
														<asp:TextBox ID="Input_DueDt" runat="server" Width="300px">2018-02-24T13:26:59+03:00</asp:TextBox>
													</asp:TableCell>
												</asp:TableRow>
												<asp:TableRow runat="server">
													<asp:TableCell class="auto-style3">Expiry Date:</asp:TableCell>
													<asp:TableCell class="auto-style3">
														<asp:TextBox ID="Input_ExpDt" runat="server" Width="300px">2018-07-24T13:26:59+03:00</asp:TextBox>
													</asp:TableCell>
												</asp:TableRow>
												<asp:TableRow runat="server">
													<asp:TableCell class="auto-style3">Open Date:</asp:TableCell>
													<asp:TableCell class="auto-style3">
														<asp:TextBox ID="Input_OpenDt" runat="server" Width="300px"></asp:TextBox>
													</asp:TableCell>
												</asp:TableRow>
												<asp:TableRow runat="server">
													<asp:TableCell class="auto-style3">Close Date:</asp:TableCell>
													<asp:TableCell class="auto-style3">
														<asp:TextBox ID="Input_CloseDt" runat="server" Width="300px"></asp:TextBox>
													</asp:TableCell>
												</asp:TableRow>
												<asp:TableRow runat="server">
													<asp:TableCell class="auto-style3">Customer ID Number:</asp:TableCell>
													<asp:TableCell class="auto-style3">
														<asp:TextBox ID="Input_CustomerIDNo" runat="server" Width="300px">12345</asp:TextBox>
													</asp:TableCell>
												</asp:TableRow>
												<asp:TableRow runat="server">
													<asp:TableCell class="auto-style3">Customer ID Type Code:</asp:TableCell>
													<asp:TableCell class="auto-style3">
														<asp:TextBox ID="Input_CustomerIDTypeCD" runat="server" Width="300px">NAT</asp:TextBox>
													</asp:TableCell>
												</asp:TableRow>
												<asp:TableRow runat="server">
													<asp:TableCell class="auto-style3">Invoice Status Code:</asp:TableCell>
													<asp:TableCell class="auto-style3">
														<asp:TextBox ID="Input_InvoiceSttsCD" runat="server" Width="300px">BillNew</asp:TextBox>
													</asp:TableCell>
												</asp:TableRow>
												<asp:TableRow runat="server">
													<asp:TableCell class="auto-style3">Bill Category:</asp:TableCell>
													<asp:TableCell class="auto-style3">
														<asp:TextBox ID="Input_BillCategory" runat="server" Width="300px">BillNew</asp:TextBox>
													</asp:TableCell>
												</asp:TableRow>
											</asp:Table>
										</asp:TableCell>
									</asp:TableRow>
									<asp:TableRow ID="BillingInfo1" runat="server">
										<asp:TableCell>
											<asp:Table ID="dt3" runat="server">
												<asp:TableHeaderRow runat="server">
													<asp:TableHeaderCell class="auto-style1" Width="300px">Billing Info.</asp:TableHeaderCell>
													<asp:TableHeaderCell class="auto-style1"></asp:TableHeaderCell>
												</asp:TableHeaderRow>
												<asp:TableRow runat="server">
													<asp:TableCell class="auto-style3">Invoice Type Code:</asp:TableCell>
													<asp:TableCell class="auto-style3">
														<asp:TextBox ID="Input_InvTypCD" runat="server" Width="300px">018</asp:TextBox>
													</asp:TableCell>
												</asp:TableRow>
												<asp:TableRow runat="server">
													<asp:TableCell class="auto-style3">Service Code:</asp:TableCell>
													<asp:TableCell class="auto-style3">
														<asp:TextBox ID="Input_SrvCD" runat="server" Width="300px">12</asp:TextBox>
													</asp:TableCell>
												</asp:TableRow>
												<asp:TableRow runat="server">
													<asp:TableCell class="auto-style3">Customer ID:</asp:TableCell>
													<asp:TableCell class="auto-style3">
														<asp:TextBox ID="Input_CusId" runat="server" Width="300px">12</asp:TextBox>
													</asp:TableCell>
												</asp:TableRow>
												<asp:TableRow runat="server">
													<asp:TableCell class="auto-style3">Payment Responsible ID:</asp:TableCell>
													<asp:TableCell class="auto-style3">
														<asp:TextBox ID="Input_PmtRespId" runat="server" Width="300px">12</asp:TextBox>
													</asp:TableCell>
												</asp:TableRow>
												<asp:TableRow runat="server">
													<asp:TableCell class="auto-style3">Start Date:</asp:TableCell>
													<asp:TableCell class="auto-style3">
														<asp:TextBox ID="Input_StartDate" runat="server" Width="300px">2018-05-01T10:47:39.995+02:00</asp:TextBox>
													</asp:TableCell>
												</asp:TableRow>
												<asp:TableRow runat="server">
													<asp:TableCell class="auto-style3">End Date:</asp:TableCell>
													<asp:TableCell class="auto-style3">
														<asp:TextBox ID="Input_EndDate" runat="server" Width="300px">2018-05-01T10:47:39.995+02:00</asp:TextBox>
													</asp:TableCell>
												</asp:TableRow>
												<asp:TableRow runat="server">
													<asp:TableCell class="auto-style3">Discount:</asp:TableCell>
													<asp:TableCell class="auto-style3">
														<asp:TextBox ID="Input_Discount" runat="server" Width="300px">0</asp:TextBox>
													</asp:TableCell>
												</asp:TableRow>
												<asp:TableRow runat="server">
													<asp:TableCell class="auto-style3">Is invoice Lump sum:</asp:TableCell>
													<asp:TableCell class="auto-style3">
														<asp:TextBox ID="Input_IsLumpSum" runat="server" Width="300px">Y</asp:TextBox>
													</asp:TableCell>
												</asp:TableRow>
												<asp:TableRow runat="server">
													<asp:TableCell class="auto-style3">Invoice initiator:</asp:TableCell>
													<asp:TableCell class="auto-style3">
														<asp:TextBox ID="Input_PmtInitiator" runat="server" Width="300px">Pmt_TEST</asp:TextBox>
													</asp:TableCell>
												</asp:TableRow>
												<asp:TableRow runat="server">
													<asp:TableCell class="auto-style3">General Notes:</asp:TableCell>
													<asp:TableCell class="auto-style3">
														<asp:TextBox ID="Input_Notes" runat="server" Width="300px">Transaction Number: 431635803</asp:TextBox>
													</asp:TableCell>
												</asp:TableRow>
											</asp:Table>
										</asp:TableCell>
									</asp:TableRow>
									<asp:TableRow ID="InvoiceLineItemsList1" runat="server">
										<asp:TableCell>
											<asp:Table ID="InvoiceLineItemInfo1" runat="server">
												<asp:TableHeaderRow runat="server">
													<asp:TableHeaderCell class="auto-style1" Width="300px">Invoice Line Item Info</asp:TableHeaderCell>
													<asp:TableHeaderCell class="auto-style1"></asp:TableHeaderCell>
												</asp:TableHeaderRow>
												<asp:TableRow runat="server">
													<asp:TableCell class="auto-style3">Line Quantity:</asp:TableCell>
													<asp:TableCell class="auto-style3">
														<asp:TextBox ID="Input_LineQuantity1" runat="server" Width="300px">10</asp:TextBox>
													</asp:TableCell>
												</asp:TableRow>
												<asp:TableRow runat="server">
													<asp:TableCell class="auto-style3">Line Rate(Item price):</asp:TableCell>
													<asp:TableCell class="auto-style3">
														<asp:TextBox ID="Input_LineRate1" runat="server" Width="300px">10</asp:TextBox>
													</asp:TableCell>
												</asp:TableRow>
											</asp:Table>
										</asp:TableCell>
									</asp:TableRow>
									<asp:TableRow runat="server">
										<asp:TableCell>
											<asp:Button ID="AddInvLine_Button" runat="server" Text="Add Item" OnClick="AddInvoiceLine_Button_Click" />
										</asp:TableCell>
									</asp:TableRow>
								</asp:Table>
							</asp:TableCell>
						</asp:TableRow>
						<asp:TableFooterRow runat="server">
							<asp:TableCell Style="text-align: right;">
								<asp:Button ID="InvokeRequest_Button" runat="server" Text="Invoke" OnClick="InvokeRequest_Button_Click" />
							</asp:TableCell>
						</asp:TableFooterRow>
					</asp:Table>
			</div>
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
							<asp:Label ID="Label3" runat="server" Text="Label3" ForeColor="Blue"></asp:Label>
						</td>
					</tr>
					<tr>
						<td class="auto-style4">Is Bill Uploaded:</td>
						<td class="auto-style4">
							<asp:Label ID="Label4" runat="server" Text="Label4" ForeColor="Blue"></asp:Label>
						</td>
					</tr>
					<tr>
						<td class="auto-style4">Is Bill Cancelled:</td>
						<td class="auto-style4">
							<asp:Label ID="Label5" runat="server" Text="Label4" ForeColor="Blue"></asp:Label>
						</td>
					</tr>
				</table>
		</div>
		</form>
	</div>
</body>
</html>
