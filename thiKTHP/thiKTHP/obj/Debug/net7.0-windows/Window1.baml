   M S B A M L   `   `   `  ����B  >thiKTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:thiKTHPthiKTHP  5   	       thiKTHP.Window1   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:thiKTHP     5   	     � Title$  Window1��5   	   $	��450��6   $	��800��6&    � 	Resources 5	       
  txtbox �� 
TargetType �� Property �� Value  datagird&   System.Windows.Controls.DataGrid  headerstyle=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%�  &	        &	 �     &	 �     �� 5
   
   " ��6   .�5      ��  � ��$ Times New Roman)�6+   �� 5       � ��$ 13(�6)   �� 5       � ��$ Italic$�6*   5      �� 5   
   "  6!   .�5      ��  �@ ColumnHeaderStyle# �  62   5      �� 5   
   "  6$   .�5      ��  � ��$ Center=�6;   �� 5       � ��$
 Bold"�6+   5      5      .��5      � .+�5   
     -   5          Name$ datagrid��5      #���  6%   $��Center=�6H   $	��Top=�6e   $	��187��6~   $��	0,107,0,0q�6�      CanUserAddRows$ False��6�      AutoGenerateColumns$ False��6�      AlternatingRowBackground
 �����	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Mã sp��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 64   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6@   �� *MaSp+  5      $
 Tên sp��6%   $	 120 65    6A   �� *TenSp+  5      $
 Tên loại��6%   $	 100 67    6C   �� *	TenLoai+  5      $
 
Đơn giá��6%   $	 100 66    6B   �� *DonGia+  5      $
 Thành tiền��6%   $	 100 69    6E   �� *	thanhtien+5!      5"      5#      