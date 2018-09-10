Imports MySql.Data.MySqlClient

Public Class _Donor

    Public Shared reader As MySqlDataReader

    Public seqno As String = Nothing
    Public fname As String = Nothing
    Public mname As String = Nothing
    Public lname As String = Nothing
    Public gender As String = Nothing
    Public bdate As String = Nothing
    Public nostblk As String = Nothing
    Public brgy As String = Nothing
    Public city As String = Nothing
    Public prov As String = Nothing
    Public region As String = Nothing
    Public donation_stat As String = Nothing

    Public hasLfinger As Boolean
    Public hasRfinger As Boolean
    Public lfinger_template As DPFP.Template
    Public rfinger_template As DPFP.Template
    Public photo As Bitmap = Nothing


    Public Shared Function find(seqno As String) As _Donor
        Dim sqlregion As String = " (select regname from rregion where regcode = donor.home_region) as region "
        Dim sqlprov As String = " (select provname from rprov where provcode = donor.home_prov) as prov "
        Dim sqlcity As String = " (select cityname from rcitymun where citycode = donor.home_citymun) as city "
        Dim sqlbrgy As String = " (select bgyname from rbrgy where bgycode = donor.home_brgy) as brgy "
        Dim fields As String = "seqno, "
        fields &= "fname, "
        fields &= "IF(mname IS NULL, '' , mname) as `mname`, "
        fields &= "lname, "
        fields &= "gender, "
        fields &= "DATE_FORMAT(bdate, '%d/%m/%Y') as bdate, "
        fields &= "IF(home_no_st_blk IS NOT NULL, home_no_st_blk, '') as home_no_st_blk, "
        fields &= sqlregion & ", "
        fields &= sqlprov & ", "
        fields &= sqlcity & ", "
        fields &= sqlbrgy & ", "
        fields &= "IF(lfinger IS NOT NULL, true, false) as lfinger, "
        fields &= "If(rfinger IS NOT NULL,true,false) as rfinger, "
        fields &= "donation_stat, "
        fields &= "lfinger, "
        fields &= "rfinger, "
        fields &= "donor_photo "
        reader = Database.db.execute("SELECT " & fields & " FROM donor WHERE seqno = '" & seqno & "'")

        Dim donor As New _Donor
        Dim ms1 As IO.MemoryStream
        Dim ms2 As IO.MemoryStream
        Dim lfbytes As Byte()
        Dim rfbytes As Byte()

        Dim photoMS As IO.MemoryStream
        Dim photoBytes As Byte()

        While reader.Read
            donor.seqno = reader(0).ToString
            donor.fname = reader(1).ToString
            donor.mname = reader(2).ToString
            donor.lname = reader(3).ToString
            donor.gender = reader(4).ToString
            donor.bdate = reader(5).ToString
            donor.nostblk = reader(6).ToString
            donor.region = reader(7).ToString
            donor.prov = reader(8).ToString
            donor.city = reader(9).ToString
            donor.brgy = reader(10).ToString
            donor.hasLfinger = reader(11)
            donor.hasRfinger = reader(12)
            donor.donation_stat = reader(13).ToString

            If Not reader(14).ToString = "" Then
                lfbytes = reader(14)
                ms1 = New IO.MemoryStream(lfbytes)
                donor.lfinger_template = New DPFP.Template(ms1)
            End If

            If Not reader(15).ToString = "" Then
                rfbytes = reader(15)
                ms2 = New IO.MemoryStream(rfbytes)
                donor.rfinger_template = New DPFP.Template(ms2)
            End If

            If Not reader(16).ToString = "" Then
                photoBytes = reader(16)
                photoMS = New IO.MemoryStream(photoBytes)
                donor.photo = New Bitmap(photoMS)
            End If

        End While

        Return donor
    End Function


End Class
