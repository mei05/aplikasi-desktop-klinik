   M S B A M L   `   `   `  ����F  BProject_UAS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Project_UASProject_UAS  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089M4clr-namespace:System.Globalization;assembly=mscorlibSystem.Globalization 5   	       Project_UAS.Data_Pasien   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Project_UAS     5   	   NGlobalization4clr-namespace:System.Globalization;assembly=mscorlib     5   	     � Title$  Data_Pasien��5	   	   $	��600��6   $
��1000��6*   .��5
      � .+�5   
   �� $'��!E:\.Sem4\BAD\Project_UAS\base.jpg��6   $��UniformToFill=�6;    J� Opacity$
 0.85Q�6S   o� 5   
   
������ $��Center=�6(   $��31��6E   $	��Top=�6Q   $	��782��6i   $��73,10,137,0q�6u   .@�5      m� -   5         m�Name$ mnLogin��5   '   $��_Login��6   
�������$	��142��6P   $��20(�6\   $��Black"�6j   m� 5      -   5        $ mnPasien��5   (   $��_Pasien��6   
�������$��26��6R   $	��167��6^   $��30,0,0,0q�6j   $��20(�6|   $��Black"�6�   .@�5      m� -   5        $ mnPasienLama��5   1   $��_Pasien Lama��6   
�������$��14(�6Z   m� 5      -   5        $ mnPasienBaru��5   1   $��_Pasien Baru��6   
�������$��14(�6Z   6h   5      m� 5      -   5        $ mnDokter��5   (   $��_Dokter��6   
�������$	��157��6R   $��20(�6^   $��Black"�6l   .@�5      m� -   5        $ mnDokterLama��5   1   $��_Data Dokter��6   
�������$��14(�6Z   6h   m� 5      -   5        $ mnDokterBaru��5   3   $��_Tambah Dokter��6   
�������$��14(�6\   6j   5      m� 5      -   5        $ mnObat��5   )   $��_Layanan��6   
�������$	��131��6Q   $��20(�6]   $��Black"�6k   .@�5      m� -	   5        $ 
mnObatLama��5   2   $��_Data Layanan��6   
�������$��14(�6Y   m� 5      -
   5        $ 
mnObatBaru��5   4   $��_Tambah Layanan��6   
�������$��14(�6[   6i   5      m� 5      -   5        $ 
mTransaksi��5   +   $��
_Transaksi��6   
�������$	��142��6W   $��20(�6c   $��Black"�6q   .@�5      m� -   5        $ mnTransaksi��5   6   $��_Tambah Transaksi��6   
�������$��14(�6^   6l   m� 5      -   5        $ mnHTransaksi��5   7   $��_Riwayat Transaksi��6   
�������$��14(�6`   6n   5      5      �� 5    
   .+�5!      &   System.Windows.Controls.DataGrid  -   5          Name$ tabel��5!      
����  �$��Visible=�6h      HeadersVisibility$	 All=�6�   
������ $��Black"�6�   $��14(�6�   ��.    AutoGenerateColumns .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6G  $��12,250q�6W     Columns 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn   Header$ Kode Pasien��6)   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6>   �� *kode_pasien+  5$      $ Nama Pasien��6)   	 6>   �� *nama_pasien+  5%      $ Alamat��6)   	 69   �� *alamat+  5&      $ Tempat Lahir��6)   	 6?   �� *tempat_lahir+4  .System.Windows.Controls.DataGridTemplateColumn  5'      $ Tanggal Lahir��6-   
   CellTemplate
 5(      �� 5)      .R�5*   "   �� ��6,   �� *tanggal_lahir+5+         CellEditingTemplate 5-      �� 5.      .R�5/   "   (  "System.Windows.Controls.DatePicker     SelectedDate 6-   �� *tanggal_lahir+ � DataContext 50   &   -  'System.Globalization.DateTimeFormatInfo  51   *      DateSeparator$ -��6K      FullDateTimePattern$ dddd, dd MMMM yyyy��52   *      LongDatePattern$ dddd, dd MMMM yyyy��6S      LongTimePattern$  ��6x      ShortTimePattern$  ��6�      TimeSeparator$  ��6�   54   #   55      57        58      $ Jenis Kelamin��6)   	 6@   �� *jenis_kelamin+  59      $ Agama��6)   	 68   �� *agama+  5:      $ Status��6)   	 69   �� *status+5<      5=      �� 5>   
   -   5        $
��Ubah��5>      
����� �
�������$��15(�6N   $
��Bold"�6\   $
��Left=�6n   $��26��6�   $��884,202,0,0q�6�   $	��Top=�6�   $��78��6�    J� RenderTransformOrigin$ -13.888,12.281&�6�   6�   �� 5?   
   -   5        $��Keluar��5?      
���  ��
�������$��18(�6F   $
��Bold"�6T   $
��Left=�6f   $��26��6�   $��
884,10,0,0q�6�   $	��Top=�6�   $��77��6�   6�   �� 5@   
   $��Data Pasien��6   $��Cambria)�6&   $��25(�6;   $��	ExtraBold"�6I   
�������$
��Left=�6z   $��37��6�   $��	44,45,0,0q�6�   $	��Top=�6�   $	��275��6�   �� 5A   
   -   5         ��Name$
 kode��5A      $
��Left=�6    $��23��6;   $��
145,90,0,0q�6G    �� TextWrapping$
 Wrap=�6[   $	��Top=�6o   $	��288��6�   �� 5B   
   $��Kode Pasien��6   $��Cambria)�6&   $��12(�6;   $��	ExtraBold"�6I   
�������$
��Left=�6z   $��23��6�   $��	41,90,0,0q�6�   $	��Top=�6�   $	��102��6�   �� 5C   
   -   5        $
 nama��5C      $
��Left=�6    $��23��6;   $��145,124,0,0q�6G   $
 Wrap=�6\   $	��Top=�6p   $	��288��6�   �� 5D   
   $��Nama Pasien��6   $��Cambria)�6&   $��12(�6;   $��	ExtraBold"�6I   
�������$
��Left=�6z   $��23��6�   $��
41,126,0,0q�6�   $	��Top=�6�   $	��102��6�   �� 5E   
   -   5        $ alamat��5E      $
��Left=�6"   $��23��6=   $��145,160,0,0q�6I   $
 Wrap=�6^   $	��Top=�6r   $	��288��6�   �� 5F   
   $��Alamat Pasien��6   $��Cambria)�6(   $��12(�6=   $��	ExtraBold"�6K   
�������$
��Left=�6|   $��23��6�   $��
41,160,0,0q�6�   $	��Top=�6�   $	��102��6�   �� 5G   
   $��Tanggal Lahir��6   $��Cambria)�6(   $��12(�6=   $��	ExtraBold"�6K   
�������$
��Left=�6|   $��23��6�   $��
477,90,0,0q�6�   $	��Top=�6�   $	��102��6�   �� 5I   
   $��Jenis Kelamin��6   $��Cambria)�6(   $��12(�6=   $��	ExtraBold"�6K   
�������$
��Left=�6|   $��23��6�   $��477,122,0,0q�6�   $	��Top=�6�   $	��102��6�   �� 5J   
   -   5         ��Name$ agama��5J      $��30��6"   $��581,156,123,383q�6.    �� SelectedValuePath$ Content��6G   .@�5K      �� .��6   Islam6"   �� 5L      .��6   	Kristen6$   �� 5M      .��6   	Katolik6$   �� 5N      .��6   Hindu6"   �� 5O      .��6   Buddha6#   �� 5P      .��6   	Khonghucu6&   �� 5Q      .��6   	Lainnya6$   5R      �� 5S   
   $��Agama��6   $��Cambria)�6    $��12(�65   $��	ExtraBold"�6C   
�������$
��Left=�6t   $��23��6�   $��477,156,0,0q�6�   $	��Top=�6�   $	��102��6�   �� 5T   
   -   5        $ tempat_lahir��5T      $
��Left=�6(   $��23��6C   $��145,196,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��288��6�   �� 5U   
   $��Tempat Lahir��6   $��Cambria)�6'   $��12(�6<   $��	ExtraBold"�6J   
�������$
��Left=�6{   $��23��6�   $��
41,196,0,0q�6�   $	��Top=�6�   $	��102��6�   �� 5V   
   $��Status��6   $��Cambria)�6!   $��12(�66   $��	ExtraBold"�6D   
�������$
��Left=�6u   $��23��6�   $��477,196,0,0q�6�   $	��Top=�6�   $	��102��6�   �� 5W   
   -   5        $ status��5W      $��30��6#   $��581,194,123,345q�6/   $ Content��6H   .@�5X      �� .��6   Belum Menikah6*   �� 5Y      .��6   Sudah Menikah6*   5Z      �� 5[   
   -   5        $ jenis_kelamin��5[      $��30��6*   $��581,120,123,419q�66   $ Content��6O   .@�5\      �� .��6   	Perempuan6&   �� 5]      .��6   	Laki-Laki6&   5^        5_   
   -   5          Name$ tanggal_lahir��5_      $
��Left=�6,   $��
584,90,0,0q�6G   $	��Top=�6[   $	��285��6s   5a      5b      