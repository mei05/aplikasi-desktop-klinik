   M S B A M L   `   `   `  ����F  BProject_UAS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Project_UASProject_UAS  5   	       Project_UAS.Data_Dokter   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Project_UAS     5   	     � Title$  Data_Dokter��5   	   $	��600��6   $
��1000��6*   .��5	      � .+�5
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
�������$��14(�6Z   m� 5      -   5        $ mnDokterBaru��5   3   $��_Tambah Dokter��6   
�������$��14(�6\   6j   5      m� 5      -   5        $ mnObat��5   )   $��_Layanan��6   
�������$	��131��6Q   $��20(�6]   $��Black"�6k   .@�5      m� -	   5        $ 
mnObatLama��5   2   $��_Data Layanan��6   
�������$��14(�6Y   6g   m� 5      -
   5        $ 
mnObatBaru��5   4   $��_Tambah Layanan��6   
�������$��14(�6[   6i   5      m� 5      -   5        $ 
mTransaksi��5   +   $��
_Transaksi��6   
�������$	��142��6W   $��20(�6c   $��Black"�6q   .@�5      m� -   5        $ mnTransaksi��5   6   $��_Tambah Transaksi��6   
�������$��14(�6^   6l   m� 5      -   5        $ mnHTransaksi��5   7   $��_Riwayat Transaksi��6   
�������$��14(�6`   6n   5      5      �� 5   
   .+�5       &   System.Windows.Controls.DataGrid  -   5          Name$ tabel��5       
����  �$��Visible=�6h      HeadersVisibility$	 All=�6�   $��Black"�6�   $��14(�6�   ��.    AutoGenerateColumns .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6.  $��10,200q�6>     Columns 5&      0  *System.Windows.Controls.DataGridTextColumn  5'      ,  &System.Windows.Controls.DataGridColumn   Header$ Kode Dokter��6)   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6>   �� *kode_dokter+  5(      $ Nama Dokter��6)   	 6>   �� *nama_dokter+  5)      $ Alamat��6)   	 69   �� *alamat+  5*      $ Alumnus��6)   	 6:   �� *
pendidikan+  5+      $ Telepon��6)   	 6:   �� *	no_telp+  5,      $ 	Spesialis��6)   	 6<   �� *	spesialis+5.      5/      �� 50   
   -   5        $
��Ubah��50      
����� �
�������$��15(�6N   $
��Bold"�6\   $
��Left=�6n   $��26��6�   $��884,156,0,0q�6�   $	��Top=�6�   $��78��6�   
 J� RenderTransformOrigin$
 -13.888,12.281&�6�   6�   �� 51   
   -   5        $��Keluar��51      
���  ��
�������$��18(�6F   $
��Bold"�6T   $
��Left=�6f   $��26��6�   $��
884,10,0,0q�6�   $	��Top=�6�   $��77��6�   6�   �� 52   
   $��Data Dokter��6   $��Cambria)�6&   $��25(�6;   $��	ExtraBold"�6I   
�������$
��Left=�6z   $��37��6�   $��	32,48,0,0q�6�   $	��Top=�6�   $	��275��6�   �� 53   
   -   5         ��Name$
 kode��53      $
��Left=�6    $��23��6;   $��
145,90,0,0q�6G    �� TextWrapping$
 Wrap=�6[   $	��Top=�6o   $	��288��6�   �� 54   
   $��Kode Dokter��6   $��Cambria)�6&   $��12(�6;   $��	ExtraBold"�6I   
�������$
��Left=�6z   $��23��6�   $��	41,90,0,0q�6�   $	��Top=�6�   $	��102��6�   �� 55   
   -   5        $
 nama��55      $
��Left=�6    $��23��6;   $��145,122,0,0q�6G   $
 Wrap=�6\   $	��Top=�6p   $	��288��6�   �� 56   
   $��Nama Dokter��6   $��Cambria)�6&   $��12(�6;   $��	ExtraBold"�6I   
�������$
��Left=�6z   $��23��6�   $��
41,122,0,0q�6�   $	��Top=�6�   $	��102��6�   �� 57   
   -   5        $ alamat��57      $
��Left=�6"   $��23��6=   $��145,156,0,0q�6I   $
 Wrap=�6^   $	��Top=�6r   $	��288��6�   �� 58   
   $��Alamat Dokter��6   $��Cambria)�6(   $��12(�6=   $��	ExtraBold"�6K   
�������$
��Left=�6|   $��23��6�   $��
41,156,0,0q�6�   $	��Top=�6�   $	��102��6�   �� 59   
   -   5        $ 
pendidikan��59      $
��Left=�6&   $��23��6A   $��
581,90,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��288��6�   �� 5:   
   $��Lulusan��6   $��Cambria)�6"   $��12(�67   $��	ExtraBold"�6E   
�������$
��Left=�6v   $��23��6�   $��
477,90,0,0q�6�   $	��Top=�6�   $	��102��6�   �� 5;   
   -   5        $ no_telp��5;      $
��Left=�6#   $��23��6>   $��581,122,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��288��6�   �� 5<   
   $��No. Telepon��6   $��Cambria)�6&   $��12(�6;   $��	ExtraBold"�6I   
�������$
��Left=�6z   $��23��6�   $��477,122,0,0q�6�   $	��Top=�6�   $	��102��6�   �� 5=   
   -   5         ��Name$ 	spesialis��5=      $��30��6&   $��581,156,123,383q�62    �� SelectedValuePath$ Content��6K   .@�5>      �� .��6   Umum6!   �� 5?      .��6   Anak6!   �� 5@      .��6   Kulit dan Kelamin6.   �� 5A      .��6   	Kandungan6&   �� 5B      .��6   	Psikologi6&   5C      �� 5D   
   $��	Spesialis��6   $��Cambria)�6$   $��12(�69   $��	ExtraBold"�6G   
�������$
��Left=�6x   $��23��6�   $��477,156,0,0q�6�   $	��Top=�6�   $	��102��6�   5E      5F      