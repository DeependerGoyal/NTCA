﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PrintButton.ascx.cs" Inherits="WiseThink.NTCA.UserControls.PrintButton" %>
<a href="javascript:void();" class="print" onclick="javascript:PrintDocuments('<% =this.printDivID%>','<% =this.printRowPerPage%>')" id="printButton">&nbsp;</a>