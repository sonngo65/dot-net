   M S B A M L   `   `   `  ����H  DQuanlyBanhang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:QuanlyBanhangQuanlyBanhang  5   	       QuanlyBanhang.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:QuanlyBanhang     5   	   -   5          � Title$  
MainWindow��5   	   $	��500��6   $	��800��6)    � 	Resources 5         DataGridStyle1 �� 
TargetType&   System.Windows.Controls.DataGrid �� Property  ColumnHeaderStyle1 �� Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader  Btn��%�  &	        &	 X     &	 �     �� 5   
   "  6'   .�5      ��  �@ ColumnHeaderStyle# �  62   5      �� 5   
   "  6+   .�5      ��  � ��$ Center=�6;   �� 5       � ��$
 Bold"�6,   5      �� 5   
   " ��6   .�5      ��  � ��$ 60��6&   �� 5       � ��$ 30��6(   �� 5       � ��
 �   �6+   �� 5       � ��
 �����6+   5      5      .��5      � $��0,0,-30,-16q�6   .+�5   
   �� $��20(�6   $��Mã sản phẩm: ��6   $	��Top=�66   $
��Left=�6N   $��	60,20,0,0q�6i   �� 5   
   -   5        $��txtMa��5      $	��Top=�6    $
��Left=�68   $	��200��6S   $��30��6_   $��
250,20,0,0q�6k   
����  �6�   �� 5    
   $��20(�6   $��Tên sản phẩm: ��6   $	��Top=�68   $
��Left=�6P   $��	60,70,0,0q�6k   �� 5!   
   -   5        $��txtTen��5!      $	��Top=�6    $
��Left=�68   $	��200��6S   $��30��6_   $��
250,70,0,0q�6k   
����  �6�   �� 5"   
   $��20(�6   $��Đơn giá: ��6   $	��Top=�62   $
��Left=�6J   $��
60,120,0,0q�6e   �� 5#   
   -   5        $��txtDon��5#      $	��Top=�6    $
��Left=�68   $	��200��6S   $��30��6_   $��250,120,0,0q�6k   
����  �6�   �� 5$   
   $��20(�6   $��Số lượng bán: ��6   $	��Top=�67   $
��Left=�6O   $��
60,170,0,0q�6j   �� 5%   
   -   5        $��txtSo1��5%      $	��Top=�6    $
��Left=�68   $	��200��6S   $��30��6_   $��250,170,0,0q�6k   
����  �6�   �� 5&   
   $��20(�6   $��Tiền bán: ��6   $	��Top=�63   $
��Left=�6K   $��
60,220,0,0q�6f   �� 5'   
   -   5        $��txtTien��5'      $	��Top=�6!   $
��Left=�69   $	��200��6T   $��30��6`   $��250,220,0,0q�6l   
����  �6�   �� 5(   
   $��20(�6   $��Nhóm hàng: ��6   $	��Top=�64   $
��Left=�6L   $��
60,270,0,0q�6g   �� 5)   
   -   5        $��cmbox��5)      $	��Top=�6    $
��Left=�68   $	��200��6S   $��30��6_   $��250,270,0,0q�6k   5,        5-   
   -   5        $
��list��5-   g      AutoGenerateColumns$ False��64      CanUserAddRows$ False��6P   $	��Top=�6u   $
��Left=�6�   #���   6�   $	��100��6�   $	��600��6�   $��108,312,0,0q�6�      Columns 5/      0  *System.Windows.Controls.DataGridTextColumn  50      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã Sản phẩm��6?   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 100 6T   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6%   �� *Masp+6T     53      $ Tên Sản phẩm��6D   $		 100 6Z   
 6%   �� *
Tensanpham+6Z     54      $ Đơn giá ��6A   $		 100 6S   
 6%   �� *Dongia+6S     55      $ Số lượng bán��6E   $		 100 6[   
 6&   �� *
Soluongban+6[     56      $ Nhóm hàng��6E   $		 100 6X   
 6%   �� *
Manhomhang+6X     57      $ Tiền bán��6B   $		 100 6T   
 6%   �� *	Tienban+6T   59      �� 5:   
   -	   5        $��Thêm��5:   !   #���  60   $��270,431,500,39q�6N   �� 5;   
   -
   5        $
��Tìm��5;   $   #���  62   $��484,431,286,39q�6P   5<      5=      