<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output method="html" version="1.0" encoding="UTF-8" indent="yes"/>

			
<xsl:template match="/attendance_system">
<!--

<xsl:value-of select="users/students/student[1]/id"/>
<xsl:value-of select="users/students/student[1]/name"/>
<xsl:value-of select="users/students/student[1]/age"/>
<xsl:value-of select="users/students/student[1]/date_of_joining"/>
<xsl:value-of select="users/students/student[1]/email"/>
<xsl:value-of select="users/students/student[1]/password"/>
 -->
 
 
 
 <html>
		<head>
			<title>Data For All Teachers</title>
		</head>
		<body>
<table width="200" cellpadding="8" cellspacing="5" align="center" border="2">
<thead>
	<tr>
		<th>ID</th>
		<th>Name</th>
		<th>Age</th>
		<th>Date Of Joining</th>
		<th>Email</th>
	</tr>
</thead>
	<tbody>
		<xsl:for-each select="//teacher" >
<tr>
	<td>
<xsl:value-of select="id"/>	
	</td>
	<td>
<xsl:value-of select="name"/>	
	</td>
	<td>
<xsl:value-of select="age"/>	
	</td>
	<td>
<xsl:value-of select="date_of_joining"/>	
	</td>
	<td>
<xsl:value-of select="email"/>	
	</td>
</tr>		
		</xsl:for-each>
	</tbody>
	<tfoot>
		<tr>
		<th><xsl:text>Numbe OF Teachers </xsl:text></th>
			<td colspan="4">

<xsl:value-of select="count(//teacher)"/>	
			</td>
		</tr>
	</tfoot>
</table>

		
		</body>
	</html>
	
</xsl:template>
</xsl:stylesheet>