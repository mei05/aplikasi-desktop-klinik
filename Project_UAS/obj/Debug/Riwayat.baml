   M S B A M L   `   `   `  ����F  BProject_UAS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Project_UASProject_UAS  5   	       Project_UAS.Riwayat   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Project_UAS     5   	     � Title$  Riwayat��5   	   $	��600��6   $
��1000��6&   .��5	      � .+�5
   
   �� $'��!E:\.Sem4\BAD\Project_UAS\base.jpg��6   $��UniformToFill=�6;    J� Opacity$
 0.85Q�6S   6d   o� 5   
   
������ $��Center=�6(   $��31��6E   $	��Top=�6Q   $	��782��6i   $��73,10,137,0q�6u   .@�5      m� -   5         m�Name$ mnLogin��5   '   $��_Login��6   
�������$	��142��6P   $��20(�6\   $��Black"�6j   m� 5      -   5        $ mnPasien��5   (   $��_Pasien��6   
�������$��26��6R   $	��167��6^   $��30,0,0,0q�6j   $��20(�6|   $��Black"�6�   .@�5      m� -   5        $ mnPasienLama��5   1   $��_Pasien Lama��6   
�������$��14(�6Z   6h   m� 5      -   5        $ mnPasienBaru��5   1   $��_Pasien Baru��6   
�������$��14(�6Z   6h   5      m� 5      -   5        $ mnDokter��5   (   $��_Dokter��6   
�������$	��157��6R   $��20(�6^   $��Black"�6l   .@�5      m� -   5        $ mnDokterLama��5   1   $��_Data Dokter��6   
�������$��14(�6Z   6h   m� 5      -   5        $ mnDokterBaru��5   3   $��_Tambah Dokter��6   
�������$��14(�6\   6j   5      m� 5      -   5        $ mnObat��5   )   $��_Layanan��6   
�������$	��131��6Q   $��20(�6]   $��Black"�6k   .@�5      m� -	   5        $ 
mnObatLama��5   2   $��_Data Layanan��6   
�������$��14(�6Y   6g   m� 5      -
   5        $ 
mnObatBaru��5   4   $��_Tambah Layanan��6   
�������$��14(�6[   6i   5      m� 5      -   5        $ 
mTransaksi��5   +   $��
_Transaksi��6   
�������$	��142��6W   $��20(�6c   $��Black"�6q   .@�5      m� -   5        $ mnTransaksi��5   6   $��_Tambah Transaksi��6   
�������$��14(�6^   6l   m� 5      -   5        $ mnHTransaksi��5   7   $��_Riwayat Transaksi��6   
�������$��14(�6`   5      5      �� 5    
   .+�5!      &   System.Windows.Controls.DataGrid  -   5          Name$ tabel��5!      
����  �   HeadersVisibility$	 All=�68   $��Black"�6P   $��14(�6c   ��. $��Visible=�6�      AutoGenerateColumns .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6�   $��12,100q�6     Columns 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn   Header$ Kode Transaksi��6)   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6A   �� *kode_transaksi+  5$      $ Tanggal��6)   	 6:   �� *	tanggal+  5%      $ Nama Pasien��6)   	 6>   �� *nama_pasien+  5&      $ Dokter Poli��6)   	 6>   �� *nama_dokter+  5'      $ Jenis Layanan��6)   	 6@   �� *	nama_obat+  5(      $ Total Biaya��6)   	 6>   �� *total+5:      5;      �� 5<   
   -   5        $��Keluar��5<      
���  ��
�������$��18(�6F   $
��Bold"�6T   $
��Left=�6f   $��26��6�   $��
884,10,0,0q�6�   $	��Top=�6�   $��77��6�   6�   �� 5=   
   $��Riwayat��6   $��Cambria)�6"   $��25(�67   $��	ExtraBold"�6E   
�������$
��Left=�6v   $��37��6�   $��	44,45,0,0q�6�   $	��Top=�6�   $	��275��6�   �� 5>   
   -   5        
 ��Name$

 cari��5>      $
��Left=�6    $��23��6;   $��
516,68,0,0q�6G    �� TextWrapping$
 Wrap=�6[   $	��Top=�6o   $	��288��6�   �� 5?   
   -   5        $
��Cari��5?      
�������$	 0.5Q�62   $��Cambria)�6@   $��15(�6U   $��	ExtraBold"�6c   
�������$
��Left=�6�   $��23��6�   $��
814,68,0,0q�6�   $	��Top=�6�   $��88��6�   6�   5@      5A      