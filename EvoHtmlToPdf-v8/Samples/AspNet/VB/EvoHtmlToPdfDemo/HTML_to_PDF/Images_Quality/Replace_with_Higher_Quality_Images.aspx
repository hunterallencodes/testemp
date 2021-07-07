﻿<%@ Page Title="Replace Images from HTML with Higher Quality Images in PDF" Language="vb"
	MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Replace_with_Higher_Quality_Images.aspx.vb"
	Inherits="EvoHtmlToPdfDemo.HTML_to_PDF.Images_Quality.Replace_with_Higher_Quality_Images" %>

<%@ MasterType VirtualPath="~/MasterPage.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table style="width: 100%; height: 100%">
		<tr>
			<td style="height: 20px; padding-bottom: 1px">
				<asp:Menu ID="demoMenu" runat="server" Orientation="Horizontal" Font-Bold="True"
					OnMenuItemClick="demoMenu_MenuItemClick">
					<Items>
						<asp:MenuItem Text="Live Demo" ToolTip="Live Demo" Value="Live_Demo" Selected="True">
						</asp:MenuItem>
						<asp:MenuItem Text="Description" ToolTip="Description" Value="Description"></asp:MenuItem>
						<asp:MenuItem Text="Sample Code" ToolTip="Sample Code" Value="Sample_Code"></asp:MenuItem>
					</Items>
					<StaticHoverStyle BackColor="White" Font-Underline="True" />
					<StaticMenuItemStyle Font-Size="14px" ForeColor="Black" BackColor="WhiteSmoke" BorderStyle="Solid"
						BorderWidth="1px" HorizontalPadding="20px" ItemSpacing="1px" VerticalPadding="5px"
						Font-Bold="False" Font-Underline="False" />
					<StaticSelectedStyle BackColor="White" Font-Underline="False" ForeColor="Navy" />
				</asp:Menu>
			</td>
		</tr>
		<tr>
			<td style="border: solid 1px Black; padding-top: 10px; padding-left: 10px; padding-right: 10px;
				padding-bottom: 0px">
				<table style="width: 100%; height: 100%">
					<tr>
						<td style="font-size: 14px; font-weight: bold; height: 20px; padding-bottom: 15px;
							padding-top: 5px">
							Replace Images from HTML with Higher Quality Images in PDF
						</td>
					</tr>
					<tr>
						<td style="width: 100%;">
							<asp:MultiView ID="demoMultiView" runat="server" ActiveViewIndex="0">
								<asp:View ID="liveDemoView" runat="server">
									<table style="width: 535px; height: 855px">
										<tr>
											<td style="vertical-align: top">
												<table>
													<tr>
														<td>
															EVO HTML to PDF Converter allows you to replace in the generated PDF document the
															original images from HTML document with higher quality images from the local file
															system. The Full Description and a Code Sample can be accessed from the top tabs.
														</td>
													</tr>
													<tr>
														<td style="height: 20px">
														</td>
													</tr>
													<tr>
														<td>
															<table>
																<tr>
																	<td style="padding-bottom: 5px; font-weight: bold" colspan="3">
																		HTML Page URL or Local File to Convert
																	</td>
																</tr>
																<tr>
																	<td>
																		<asp:TextBox ID="urlTextBox" runat="server" Width="435px">http://www.evopdf.com</asp:TextBox>
																	</td>
																	<td style="width: 5px">
																	</td>
																	<td>
																		<asp:LinkButton ID="viewHtmlLinkButton" runat="server" OnClick="viewHtmlLinkButton_Click">View HTML</asp:LinkButton>
																	</td>
																</tr>
															</table>
														</td>
													</tr>
													<tr>
														<td style="height: 20px">
														</td>
													</tr>
													<tr>
														<td>
															<asp:Button ID="convertToPdfButton" runat="server" Text="Convert HTML to PDF" OnClick="convertToPdfButton_Click" />
														</td>
													</tr>
												</table>
											</td>
										</tr>
									</table>
								</asp:View>
								<asp:View ID="descriptionView" runat="server">
									<div style="width: 535px; height: 855px; overflow: scroll; font-size: 11px">
										<asp:Literal ID="descriptionLiteral" runat="server"></asp:Literal>
									</div>
								</asp:View>
								<asp:View ID="sampleCodeView" runat="server">
									<div style="width: 535px; height: 855px; overflow: scroll; font-size: 11px">
										<asp:Literal ID="sampleCodeLiteral" runat="server"></asp:Literal>
									</div>
								</asp:View>
							</asp:MultiView>
						</td>
					</tr>
				</table>
			</td>
		</tr>
	</table>
</asp:Content>