   M S B A M L   `   `   `  ����A  =cuoiKy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:cuoiKycuoiKy  5   	       cuoiKy.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:cuoiKy     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	         
girdHeader �� 
TargetType&   System.Windows.Controls.DataGrid �� Property  colmnHeader �� Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader  TextBox  btn��%A  &	        &	 X     &	 �     &	 E    �� 5
   
   "  6#   .�5      ��  �@ ColumnHeaderStyle# �  62   5      �� 5      "  6,   .�5      ��  � ��$ Center=�6C   5      �� 5   
   " ��6    .�5      ��  � ��$ Times New Roman)�6+   �� 5       � ��$ Italic$�6*   �� 5       � ��$ 13(�6)   5      �� 5   
   " ��6   .�5      ��  � �� 5      �� 5      .R�5      � .+�5      A� 
����� �6"   �� 5      $��Center=�6/   $��Center=�6L   5      5      5      5       5"      .��5#      � .+�5$   
   �� $��15(�6   $��Mã sản phẩm:��6   $
��Left=�66   $��	46,37,0,0q�6Q   $	��Top=�6d   �� 5%   
   #���  6   $
��Left=�64   $��
200,37,0,0q�6O    �� TextWrapping$
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��200��6�   $��30��6�   �� 5&   
   $��15(�6   $��Tên sản phẩm:��6   $
��Left=�66   $��	46,87,0,0q�6Q   $	��Top=�6d   �� 5'   
   #���  6   $
��Left=�65   $��
200,87,0,0q�6P   $
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $	��200��6�   $��30��6�   �� 5(   
   $��15(�6   $��Loại sản phẩm:��6   $
��Left=�67   $��
46,137,0,0q�6R   $	��Top=�6f   �� 5)   
   $
��Left=�6   $��200,137,0,0q�6/    �� Text$  ��6D   $	��Top=�6L   $	��200��6d   $��30��6p   5+      �� 5,   
   $��15(�6   $��Đơn giá:��6   $
��Left=�61   $��
46,187,0,0q�6L   $	��Top=�6`   �� 5-   
   #���  6   $
��Left=�65   $��200,187,0,0q�6P   $
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��200��6�   $��30��6�   �� 5.   
   $��15(�6   $��Số lượng có:��6   $
��Left=�65   $��
46,237,0,0q�6P   $	��Top=�6d   �� 5/   
   #���  6   $
��Left=�65   $��200,237,0,0q�6P   $
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��200��6�   $��30��6�     50   
   #���   6   $	��Top=�68   $��Center=�6P   $��	0,288,0,0q�6m      Columns 51      0  *System.Windows.Controls.DataGridTextColumn  52      ,  &System.Windows.Controls.DataGridColumn   Header$ mã sp ��6&   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 80 66   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6A   �� *Masp+  53      $ tên sp��6%   $		 100 65   
 6A   �� *Tensp+  54      $ mã loại sp��6%   $	 80 69   
 6D   �� *Maloai+  55      $ 
đơn giá��6%   $	 80 66   
 6A   �� *Dongia+  56      $ thành tiền��6%   $	 80 69   
 6D   �� *	Thanhtien+58      �� 59   
   #���  6   $��40��6/   $��40��6:   $��Button��6F   $��16(�6W   
���   �$
��Left=�6x   $��200,377,0,0q�6�   $	��Top=�6�   5<      5=      