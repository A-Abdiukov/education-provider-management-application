   M S B A M L   `   `   `  ����  View    View.TeacherInformation   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      -   5          � Title$  View teachers��5       � WindowStartupLocation$ CenterScreen=�5
       � WindowStyle$ 
ToolWindow=�5      .��5      � .+�5   
   �� -   5        $��	SearchBox��5      $	��595��5      $��23��5      $��	77,52,0,0q�5      $
��Left=�5      $	��Top=�5      $&�� Enter ID that you wish to search��5       �� TextWrapping$
 Wrap=�5      �� 5   
   -   5        $��SearchButton��5      $��75��5      $��23��5      $��
692,52,0,0q�5      $
��Left=�5      $	��Top=�5      $��Search��5!      �� 5"   
   -   5        $��GoBack_navigation_btn��5#      $��25��5$      $��25��5%      $��	10,10,0,0q�5&      $
��Left=�5'      $	��Top=�5(      $	��<--��5*      &   System.Windows.Controls.DataGrid  5+   
   -   5        $��DgTeacherProfiles��5,      $��
0,160,0,10q�5-      $��Stretch=�5.      $��Stretch=�5/         AutoGenerateColumns .  $��Verdana)�51      $��12(�52         
IsReadOnly . "   VerticalScrollBarVisibility$ Visible=�55         Columns 56      0  *System.Windows.Controls.DataGridTextColumn  57      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6C   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6%   �� 
 �� Path$
 Id�6C     58      $ 
First Name��6J   	 6%   �� $
 	FirstName�6J     59      $ 	Last Name��6I   	 6%   �� $
 LastName�6I     5:      $ Email��6F   	 6%   �� $
 Email�6F     5;      $ Gender��6M   	 6%   �� $
 PersonGender�6M     5<      $ Address��6H   	 6%   �� $
 Address�6H     5=      $ Date of Birth��6e   	 6%   �� $
 DateofBirth� �� StringFormat$ 
dd-MM-yyyy��6e     5>      $ Mobile��6G   	 6%   �� $
 Mobile�6G     5?      $ Position��6I   	 6%   �� $
 Position�6I     5@      $ Other than based location��6V   	 6%   �� $
 OtherThanBaseLocation�6V     5A      $ Currently teaches��6J   	 6%   �� $
 	IsCurrent�6J   4  .System.Windows.Controls.DataGridTemplateColumn  5B      $  ��6)      CellTemplate 5C      �� 5D      .R�5E      ��  �� Orientation$ 
Horizontal=�6)   .+�5F   "   �� $��Btn_CourseHistory��5G   %   -   5        $��See course history��5I   %   5J      5K      5M      5O      �� 5P   
   -   5         ��Name$ Checkbox_SearchFullTime��5Q      $��	77,80,0,0q�5R      $
��Left=�5S      $	��Top=�5T      $��	Full Time��5V      �� 5W   
   -   5        $ Checkbox_SearchPartTime��5X      $��
160,80,0,0q�5Y      $
��Left=�5Z      $	��Top=�5[      $��	Part Time��5]      �� 5^   
   -	   5        $ Checkbox_SearchPast��5_      $��
245,80,0,0q�5`      $
��Left=�5a      $	��Top=�5b      $��Not current��5c      �� 5d   
   -
   5        $ Checkbox_SearchCurrent��5e      $��
340,80,0,0q�5f      $
��Left=�5g      $	��Top=�5h      $��Current��5i      �� 5j   
   -   5        $, &Checkbox_SearchTeacherNotBasedLocation��5k      $��
77,114,0,0q�5l      $
��Left=�5m      $	��Top=�5n      $D��>Teachers who teach at location other than their based location��5o        5q   
   -   5        $��DgNavigationBar��5r      $��25��5s      $��	40,10,0,0q�5t      $��Stretch=�5u      $	��Top=�5v       .     ColumnHeaderHeight$ 0Q�5x      $��12(�5y         GridLinesVisibility$
 None=�5z         HeadersVisibility$
 None=�5{       . $ Disabled=�5~       5        5�      $  ��6F   	 6%   �� $
 Title�6F    � LayoutTransform 5�      V� 5�      .~�5�      ��  �� Angle$ 90Q�6&   u� 5�       u� Matrix$ -1,0,0,1,0,0x�6&   5�         ColumnHeaderStyle 5�      �� 5�      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn# [B 6    �� 
TargetType"  6Q   .�5�      ��  �� Property �@�LayoutTransform �� Value 5�      V� 5�      .~�5�   "   �� $	 -90Q�62   �� 5�   "    �� ScaleX$ 1Q�61    �� ScaleY$ -1Q�6<   5�      5�      5�         	CellStyle 5�      �� 5�      *  $System.Windows.Controls.DataGridCell"  6   .�5�      ��  �@�LayoutTransform 5�      V� 5�      .~�5�   "   �� $	 -90Q�62   �� 5�   "   $ 1Q�61   $ -1Q�6<   5�      5�      5�      5�      5�      5�      