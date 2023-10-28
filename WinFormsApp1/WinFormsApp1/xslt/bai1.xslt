<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/">
		<html>
			<body>
				<h1 align="center">BẢNG LƯƠNG ThÁNG 10</h1>
				<xsl:for-each select="donvi">
					<h2>
						Mã đơn vị: <xsl:value-of select="@madv"/>
					</h2>
					<h2>
						Tên đơn vị: <xsl:value-of select="tendv"/>
					</h2>
					<h2>
						Điện thoại: <xsl:value-of select="dienthoai"/>
					</h2>
					<h2 align="center">
						Dach sách nhân viên
					</h2>
					<table>
						<tr>
							<th>Số tt</th>
							<th>Mã nv</th>
							<th>họ tên</th>
							<th>ngày sinh</th>
							<th>hs lương</th>
							<th>lương</th>
						</tr>
						<xsl:for-each select="nhanvien">
							<tr>
								<td>
									<xsl:value-of select="position()"/>
								</td>
								<td>
									<xsl:value-of select="manv"/>
								</td>
								<td>
									<xsl:value-of select="ngaysinh"/>
								</td>
								<td>
									<xsl:value-of select="hsluong"/>
									
								</td>
								<td>
									<xsl:value-of select="hsluong*73000"/>
								</td>
							</tr>
						</xsl:for-each>
					</table>
				</xsl:for-each>
				<h2 align="right">ThỨ TRƯỞNG ĐƠN VỊ</h2>
				<br></br>
				<center>---------------------------------------------</center>
			</body>
		</html>
    </xsl:template>
</xsl:stylesheet>
