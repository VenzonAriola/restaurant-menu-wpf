   M S B A M L   `   `   `  ����K  GDataBinding_Lab3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:DataBinding_Lab3DataBinding_Lab3  5   	   G(clr-namespace:DataBinding_Lab3.ViewModelDataBinding_Lab3.ViewModel  5   	   !    DataBinding_Lab3.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:DataBinding_Lab3     5   	   >	ViewModel(clr-namespace:DataBinding_Lab3.ViewModel     5   	     � Title$   Restaurant Bill Calculator��5	   	   $	��530��6,   $	��600��69    � DataContext 5
      .   (DataBinding_Lab3.ViewModel.MainViewModel  5   
   .��5      � .+�5   
   �� -   5         ��Name$ cmbAppetizer��5      $
��Left=�6)   $��	95,34,0,0q�6D   $	��Top=�6W   $	��148��6o   ��5      �� *	Appetizer+��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� $��0 0 10 0q�6:   ��6$   �� *Name+6:   5      5      5      �� 5   
   -   5        $ cmbMainCourse��5      $
��Left=�6*   $��	95,81,0,0q�6E   $	��Top=�6X   $	��148��6p   ��5      �� *
MainCourse+��5      �� 5      .R�5       �� $ 
Horizontal=�6!   .+�5!      �� $��0 0 10 0q�6:   ��6$   �� *Name+6:   5$      5%      5'      �� 5(   
   $��	Appetizer��6   $
��Left=�6$   $��	10,30,0,0q�6?   $	��Top=�6R   $��80��6j   �� 5)   
   $��Main Course��6   $
��Left=�6&   $��	10,77,0,0q�6A   $	��Top=�6T   $��80��6l   �� 5*   
   $��	Beverages��6   $
��Left=�6$   $��
300,32,0,0q�6?   $	��Top=�6S   $��80��6k   �� 5+   
   $��Desserts��6   $
��Left=�6#   $��
300,79,0,0q�6>   $	��Top=�6R   $��80��6j   �� 5,   
   -   5        $ cmbBeverages��5,      $
��Left=�6)   $��
385,34,0,0q�6D   $	��Top=�6X   $	��148��6p   ��6|   �� *	Beverages+��5-      �� 5.      .R�5/      �� $ 
Horizontal=�6!   .+�50      �� $��0 0 10 0q�6:   ��6$   �� *Name+6:   53      54      56      �� 57   
   -   5        $ cmbDesserts��57      $
��Left=�6(   $��
385,83,0,0q�6C   $	��Top=�6W   $	��148��6o   ��58      �� *
Desserts+��59      �� 5:      .R�5;      �� $ 
Horizontal=�6!   .+�5<      �� $��0 0 10 0q�6:   ��6$   �� *Name+6:   5?      5@      5B      &   System.Windows.Controls.DataGrid  5C   
   -   5          Name$ SelectedMenuItems��5C      $��10,142,10,175q�6.   $��Disabled=�5D      
�������   RowBackground
 �����   AlternatingRowBackground
 ��ح�   CanUserAddRows$ False��5E   8      Columns 5F      0  *System.Windows.Controls.DataGridTextColumn  5G      ,  &System.Windows.Controls.DataGridColumn	   Header$
	 Name��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 150 6L      
IsReadOnly$
 True��6X   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Name+6X     5H      $	 Category��6%   $	
 150 6T   $
 True��6`    67   �� *
Category+6`     5I      $	 Price��6%   $
 90 6^   $
 True��6i    64   �� *price+ �� StringFormat$ C��6i     5J      $	 Quantity��6%   $
 90 6T    67   �� *
quantity+6T   4  .System.Windows.Controls.DataGridTemplateColumn  5K      $	 Delete��6)   $
 90 69      CellTemplate 5L      �� 5M      .R�5N      �� -   5        $��Remove��5N   %   66   5O      5Q      5S      �� 5T   
   $��Subtotal��6   $
��Left=�6#   $��
19,358,0,0q�6>   $	��Top=�6R   �� 5U   
   $	��Tax��6   $
��Left=�6   $��
19,389,0,0q�69   $	��Top=�6M   $��50��6e   �� 5V   
   $��Total��6   $
��Left=�6    $��
19,415,0,0q�6;   $	��Top=�6O   $��30��6g   �� 5W   
   -   5         ��Name$ TBoxSubTotal��5W      $
��Left=�6(   $��
95,363,0,0q�6C   $�� ��6W    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��120��6�   $��0q�6�   �� 5X   
   -   5        $ TBoxTax��5X      $
��Left=�6#   $��
95,394,0,0q�6>   $�� ��6R   $
 Wrap=�6Z   $	��Top=�6n   $	��120��6�   $��0q�6�   �� 5Y   
   -	   5        $ TBoxTotally��5Y      $
��Left=�6'   $��
95,422,0,0q�6B   $�� ��6V   $
 Wrap=�6^   $	��Top=�6r   $	��120��6�   $��0q�6�   ]� 5[   
   .+�5\      �� $��Bottom=�6   $��Bottom=�60   .@�5]      �� .��5^      �� $ ��Venzon Ariola - 301207576 ��6   5_      �� 5`      -
   5        $��38��5`      $	��150��6$   $��Right=�60    � Cursor$
 Hand��6v   ��5a      �� 5b       �� ImageSource$ /centennialLogo.png��6%   5d      5e      5f      �� 5g   
   -   5        $��Clear��5g      $
��Left=�6!   $��361,422,0,0q�6<   $	��Top=�6Q   $��26��6i   $��90��6u   6�   �� 5h   
   -   5        $
��Exit��5h      $
��Left=�6    $��471,422,0,0q�6;   $	��Top=�6P   $��26��6h   $��90��6t   6   5l      5t      