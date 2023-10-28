<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="congty">
		<html>
			<head>
				<title>bang luong</title>
				<link rel="stylesheet" type="text/css" href="style.css"/>
			</head>
			<body>
				<h1 align="center">Bảng lương tháng 10</h1>
				<xsl:for-each select="donvi">
					<h2>
						Mã đơn vị: <xsl:value-of select="@madv"/>

					</h2>
					<h2>
						Tên đơn vị: <xsl:value-of select="tendv"/>
					</h2>
					<h2>
						Điên thoại: <xsl:value-of select="dienthoai"/>
					</h2>
					<h2 align="center"> Danh sách nhân viên</h2>
					<table border="1" align="center">
						<tr>
							<th>số tt</th>
							<th>mã nv</th>
							<th>ho tên</th>
							<th>ngày sinh</th>
							<th>hsl lương</th>
							<th>lương</th>
						</tr>
						<xsl:for-each select="nhanvien">
							<xsl:if test="hoten='ngo son' and hsluong>3">
								<tr>
									<td>
										<xsl:value-of select="position()"/>
									</td>
									<td>
										<xsl:value-of select="manv"/>
									</td>
									<td>
										<xsl:value-of select="hoten"/>
									</td>
									<td>
										<xsl:value-of select="ngaysinh"/>
									</td>
									<td>
										<xsl:value-of select="hsluong"/>
									</td>
									<td>
										<xsl:value-of select="hsluong*74000"/>
									</td>
								</tr>
							</xsl:if>

						</xsl:for-each>
					</table>
				</xsl:for-each>
				<h1 align="right">thứ trưởng</h1>
				<center>------------------------------</center>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>
