   M S B A M L   `   `   `  ����  View"    View.Edit.EditStudentResults   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      -   5          � Title$  Edit student results��5       � WindowStartupLocation$ CenterScreen=�5
       � WindowStyle$ 
ToolWindow=�5      .��5      � .+�5   
   �� -   5        $��GoBack_navigation_btn��5      $��25��5      $��25��5      $��	10,10,0,0q�5      $
��Left=�5      $	��Top=�5      $	��<--��5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��DgNavigationBar��5      $��25��5      $��	40,10,0,0q�5      $��Stretch=�5      $	��Top=�5         AutoGenerateColumns .     ColumnHeaderHeight$ 0Q�5      $��12(�5         GridLinesVisibility$
 None=�5          HeadersVisibility$
 None=�5!         
IsReadOnly . "   VerticalScrollBarVisibility$ Disabled=�5$      	   Columns	 5%      0  *System.Windows.Controls.DataGridTextColumn  5&      ,  &System.Windows.Controls.DataGridColumn
   Header$
  ��6F   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ��  �� Path$ Title�6F    � LayoutTransform 5(      V� 5)      .~�5*      ��  �� Angle$ 90Q�6&   u� 5+       u� Matrix$ -1,0,0,1,0,0x�6&   5,         ColumnHeaderStyle 5.      �� 5/      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn# [B 6    �� 
TargetType"  6Q   .�50      ��  �� Property �@�LayoutTransform �� Value 51      V� 52      .~�53   "   �� $	 -90Q�62   �� 54   "    �� ScaleX$ 1Q�61    �� ScaleY$ -1Q�6<   55      57      58         	CellStyle 5:      �� 5;      *  $System.Windows.Controls.DataGridCell"  6   .�5<      ��  �@�LayoutTransform 5=      V� 5>      .~�5?   "   �� $	 -90Q�62   �� 5@   "   $ 1Q�61   $ -1Q�6<   5A      5C      5D      5F      �� 5H   
   $��
20,50,20,0q�6   $	��Top=�6)   .+�5I      �  � ColumnDefinitions 5J      �� 5K      �� 5L      �� 5M      $
��0.3* �6'   �� 5N      �� 5O       � RowDefinitions 5Q      �� 5R      $��50��6$   �� 5S      $��50��6$   �� 5T      $��50��6$   �� 5U      $��50��6$   �� 5V      $��50��6$   �� 5W      $��50��6$   �� 5X      $��50��6$   �� 5Y      $��50��6$   �� 5Z      $��50��6$   .+�5\      �� $��0��5]      $��0��5^      $��2��5_      $%��Select student you wish to edit��5`      �� 5a      -   5        $��ComboBoxSelectStudent��5b      $��1��5c      $��0��5d      $��2��5e       �� SelectedIndex$ 0��5f      5g      5i      5j        5k   
   -   5        $��DgStudentResults��5l      $��
0,170,0,10q�5m      $��Stretch=�5n      $��Stretch=�5o       .  $��Verdana)�5q      $��18(�5r       . $ Visible=�5u      	 5v        5w      $
 
Student id��6J    6%   �� $ 	StudentID�6J     5x      $
 Course Name��6K    6%   �� $ 
CourseName�6K     5y      $
 Course Location��6O    6%   �� $ CourseLocation�6O     5z      $
 Course Outcome��6H    6%   �� $ Outcome�6H   4  .System.Windows.Controls.DataGridTemplateColumn  5{      $
  ��6)      CellTemplate 5|      �� 5}      .R�5~      ��  �� Orientation$ 
Horizontal=�6)   .+�5   "   �� $��BtnEditOutcome��5�   %   -   5        $��Edit outcome��5�   %   5�      5�      5�      5�      5�      5�      