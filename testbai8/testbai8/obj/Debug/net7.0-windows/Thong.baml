   M S B A M L   `   `   `  ����C  ?testbai8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:testbai8testbai8  5   	       testbai8.Thong   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:testbai8     5   	     � Title$  Thong��5   	   $	��450��6   $	��800��6$    � 	Resources 5	         dataGridStyle �� 
TargetType&   System.Windows.Controls.DataGrid �� Property  headerStyle �� Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%�   &	        &	 X     �� 5
   
   "  6&   .�5      ��  �@ ColumnHeaderStyle# �  62   5      �� 5   
   "  6$   .�5      ��  � ��$ Center=�6;   5      5      .��5      � .+�5   
     -   5        $��datagrid��5       $	��100��6      AlternatingRowBackground
 �����#���   6U   $��Center=�6}   $	��Top=�6�      AutoGenerateColumns$ False��6�      CanUserAddRows$ False��6�   $��	0,276,0,0q�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 MÃ SP��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 80 6M   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *Masp+6M     5      $	 TÊN SP��6%   $	
 100 6O    65   �� *Tensp+6O     5      $	 MÃ LOẠI SP��6%   $
 80 6U    69   �� *	Tenloai+6U     5      $	 SỐ LƯỢNG��6%   $	
 100 6S    67   �� *	Soluong+6S     5      $	 
ĐƠN GIÁ��6%   $	
 100 6Q    66   �� *Dongia+6Q     5      $	 THÀNH TIỀN��6%   $	
 120 6W    69   �� *	Thanhtien+6W   5      5      5       