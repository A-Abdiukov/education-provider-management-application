   M S B A M L   `   `   `  ����  View    View.TeacherCourseHistory   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      -   5          � Title$  Teacher course history��5       � WindowStartupLocation$ CenterScreen=�5
       � WindowStyle$ 
ToolWindow=�5      .��5      � .+�5   
   �� -   5        $��GoBack_navigation_btn��5      $��25��5      $��25��5      $��	10,10,0,0q�5      $
��Left=�5      $	��Top=�5      $	��<--��5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��DgCourseHistory��5      $��	0,90,0,10q�5      $��Stretch=�5      $��Stretch=�5         AutoGenerateColumns .  $��Verdana)�5      $��18(�5         
IsReadOnly . "   VerticalScrollBarVisibility$ Visible=�5!         Columns 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn   Header$ Course name��6K   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� 	 �� Path$	 
CourseName�6K     5$      $ Semester��6I    6%   �� $	 Semester�6I     5%      $ Name of campus��6K    6%   �� $	 
CampusName�6K     5&      $ Delivery��6I    6%   �� $	 Delivery�6I     5'      $&  Course is currently being taught��6J    6%   �� $	 	IsCurrent�6J   5*      �� 5+   
   -   5        
 ��Name$
 Checkbox_SearchPastCourse��5,      $��	22,62,0,0q�5-      $
��Left=�5.      $	��Top=�5/      $��Taught in the past��51      52      �� 53   
   -   5        $"
 Checkbox_SearchPresentCourse��54      $��
142,62,0,0q�55      $
��Left=�56      $	��Top=�57      $��Currently teaches��59      5:        5;   
   -   5        $��DgNavigationBar��5<      $��25��5=      $��	40,10,0,0q�5>      $��Stretch=�5?      $	��Top=�5@       .     ColumnHeaderHeight$ 0Q�5B      $��12(�5C         GridLinesVisibility$
 None=�5D         HeadersVisibility$
 None=�5E       . $ Disabled=�5H       5I        5J      $  ��6F    6%   �� $	 Title�6F    � LayoutTransform 5L      V� 5M      .~�5N      ��  �� Angle$ 90Q�6&   u� 5O       u� Matrix$ -1,0,0,1,0,0x�6&   5P         ColumnHeaderStyle 5R      �� 5S      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn# [B 6    �� 
TargetType"  6Q   .�5T      ��  �� Property �@�LayoutTransform �� Value 5U      V� 5V      .~�5W   "   �� $	 -90Q�62   �� 5X   "    �� ScaleX$ 1Q�61    �� ScaleY$ -1Q�6<   5Y      5[      5\         	CellStyle 5^      �� 5_      *  $System.Windows.Controls.DataGridCell"  6   .�5`      ��  �@�LayoutTransform 5a      V� 5b      .~�5c   "   �� $	 -90Q�62   �� 5d   "   $ 1Q�61   $ -1Q�6<   5e      5g      5h      5j      5k      5l      