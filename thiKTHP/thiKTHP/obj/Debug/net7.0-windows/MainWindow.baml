   M S B A M L   `   `   `  ����B  >thiKTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:thiKTHPthiKTHP  5   	       thiKTHP.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:thiKTHP     5   	   -   5          � Title$  
MainWindow��5   	   $	��480��6   $	��800��6)    � 	Resources 5       
  txtbox �� 
TargetType �� Property �� Value  datagird&   System.Windows.Controls.DataGrid  headerstyle=  7System.Windows.Controls.Primitives.DataGridColumnHeader  btn �� 
TargetType��%q  &	        &	 �     &	 �     &	 k    �� 5   
   " ��6   .�5      ��  � ��$ Times New Roman)�6+   �� 5       � ��$ 13(�6)   �� 5       � ��$ Italic$�6*   5      �� 5   
   "  6!   .�5      ��  �@ ColumnHeaderStyle# �  62   5      �� 5      "  6,   .�5      ��  � ��$ Center=�6C   �� 5       � ��$
 Bold"�6+   5      �� 5   
   " ��6   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      � .+�5      A� 
����� �6&   �� 5      $��Center=�6/   $��Center=�6L   5      5       5"      5#      5%      .��5&      � .+�5'   
   �� $��Mã sản phẩm:��6   $
��Left=�6'   $��
104,40,0,0q�6B   $	��Top=�6V   �� 5(   
   -   5         ��Name$ txtMa��5(      #���   6!   $��20��6B   $
��Left=�6N   $��
226,40,0,0q�6i    �� TextWrapping$
 Wrap=�6}   $�� ��6�   $	��Top=�6�   $	��120��6�   �� 5)   
   $��Tên sản phẩm:��6   $
��Left=�6(   $��
104,90,0,0q�6C   $	��Top=�6W   �� 5*   
   -   5        $ txtTen��5*      #���   6"   $��20��6C   $
��Left=�6O   $��
226,90,0,0q�6j   $
 Wrap=�6~   $�� ��6�   $	��Top=�6�   $	��120��6�   �� 5+   
   $��Loại sản phẩm:��6   $
��Left=�6)   $��104,140,0,0q�6D   $	��Top=�6Y   �� 5,   
   -   5        $	��cmb��5,      $��20��6   $
��Left=�6*   $��226,140,0,0q�6E    �� Text$  ��6[   $	��Top=�6c   $	��120��6{   5.      �� 50   
   $��Đơn giá:��6   $
��Left=�6#   $��104,190,0,0q�6>   $	��Top=�6S   �� 51   
   -   5        $ txtDon��51      #���   6"   $��20��6C   $
��Left=�6O   $��226,190,0,0q�6j   $
 Wrap=�6   $�� ��6�   $	��Top=�6�   $	��120��6�   �� 52   
   $��Số lượng có:��6   $
��Left=�6'   $��104,240,0,0q�6B   $	��Top=�6W   �� 53   
   -   5        $ txtSo��53      #���   6!   $��20��6B   $
��Left=�6N   $��226,240,0,0q�6i   $
 Wrap=�6~   $�� ��6�   $	��Top=�6�   $	��120��6�     54   
   -   5        	  Name$	 datagrid��54   5   #���  6G   $��Center=�6j   $	��Top=�6�   $	��110��6�   $��	0,285,0,0q�6�   
   CanUserAddRows$
 False��6�      AutoGenerateColumns$ False��6�      AlternatingRowBackground
 �����   Columns 55      0  *System.Windows.Controls.DataGridTextColumn  56      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã sp��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 64   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6@   �� *MaSp+  57      $ Tên sp��6%   $	 120 65    6A   �� *TenSp+  58      $ 
Mã loại��6%   $	 100 66    6B   �� *MaLoai+  59      $ 
Đơn giá��6%   $	 100 66    6B   �� *DonGia+  5:      $ Số lượng��6%   $	 100 67    6C   �� *	SoLuong+  5;      $ Thành tiền��6%   $	 100 69    6E   �� *	thanhtien+5=      �� 5>   
   -   5        #���  5>      $��Thêm��6/   $
��Left=�6O   $��226,419,0,0q�6j   $	��Top=�6   �� 5?   
   -	   5        #���  5?      $��Sửa��6/   $
��Left=�6M   $��306,419,0,0q�6h   $	��Top=�6}   �� 5@   
   -
   5        #���  5@      $
��Xoá��6/   $
��Left=�6M   $��422,419,0,0q�6h   $	��Top=�6}   �� 5A   
   -   5        #���  5A      $
��Tìm��6/   $
��Left=�6M   $��508,419,0,0q�6h   $	��Top=�6}   5C      5D      