   M S B A M L   `   `   `  ����>  :Thi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ThiThi  5   	       Thi.timWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:Thi     5   	     � Title$  	timWindow��5   	   $	��450��6   $	��566��6(    � 	Resources 5	         datagrid �� 
TargetType&   System.Windows.Controls.DataGrid �� Property  headerStyle �� Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader  	btn_style �� 
TargetType �� Triggers P� Property P� Value��%7  &	        &	 X     &	 �     �� 5
   
   "  6!   .�5      ��  �@ ColumnHeaderStyle# �  62   5      �� 5   
   "  6$   .�5      ��  � ��$ Center=�6;   �� 5       � ��$
 Bold"�6+   5      �� 5   
   " ��6"   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      � .+�5      A� 
����+��6&   �� 5      $��Center=�6/   $��Center=�6L   5      5      5       5      P� 5       �@J�IsMouseOver$
 True��61   . �5      ��  � ��
 �  ��63   5       5"      5#      .��5$      � $	��434��6   $	��Top=�6   .+�5%   
     -   5        $��datagrid��5%       $	��155��6   $��Center=�60   $	��Top=�6M   $��0,62,0,0q�6e   #���   6w   	   AlternatingRowBackground
	 �����
   CanUserAddRows$
 False��6�      AutoGenerateColumns$ False��6�      Columns 5&      0  *System.Windows.Controls.DataGridTextColumn  5'      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã SP��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 60 64   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *Masp+  5(      $ Tên Sản Phẩm��6%   $	 100 6;    6G   �� *
Tensanpham+  5)      $ 
Đơn Giá��6%   $ 60 66    6A   �� *Dongia+  5*      $ Số lượng bán��6%   $	 100 6;    6G   �� *
Soluongban+  5+      $ Nhóm Hàng��6%   $	 100 68    6D   �� *Tennhomhang+  5,      $ Tiền bán��6%   $ 80 67    6B   �� *	tienban+5.      50      51      