   M S B A M L   `   `   `  ����  View    View.StudentInformation   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      -   5          � Title$  View students��5       � WindowStartupLocation$ CenterScreen=�5
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
   -   5        $��DgStudentProfiles��5,      $��
0,160,0,10q�5-      $��Stretch=�5.      $��Stretch=�5/         AutoGenerateColumns .  $��Verdana)�51      $��12(�52         
IsReadOnly . "   VerticalScrollBarVisibility$ Visible=�55         Columns 56      0  *System.Windows.Controls.DataGridTextColumn  57      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6C   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6%   �� 
 �� Path$
 Id�6C     58      $ 
First Name��6J   	 6%   �� $
 	FirstName�6J     59      $ 	Last Name��6I   	 6%   �� $
 LastName�6I     5:      $ Residence Address��6H   	 6%   �� $
 Address�6H     5;      $ Gender��6M   	 6%   �� $
 PersonGender�6M     5<      $ Email��6F   	 6%   �� $
 Email�6F     5=      $ Mobile��6G   	 6%   �� $
 Mobile�6G     5>      $ Date of Birth��6e   	 6%   �� $
 DateofBirth� �� StringFormat$ 
dd-MM-yyyy��6e     5?      $ Not paid��6N   	 6%   �� $
 IsFeesNotPaid�6N     5@      $ Position��6I   	 6%   �� $
 Position�6I     5A      $ Currently attends��6J   	 6%   �� $
 	IsCurrent�6J   4  .System.Windows.Controls.DataGridTemplateColumn  5B      $  ��6)      CellTemplate 5C      �� 5D      .R�5E      ��  �� Orientation$ 
Horizontal=�6)   .+�5F   "   �� $��BtnStudentResult��5G   %   -   5        $��See student results��5I   %   �� 5J   "   $��BtnStudentEnrolment��5K   %   -   5        $��See student enrolment��5M   %   5N      5O      5Q      5S      �� 5T   
   -   5         ��Name$ Checkbox_SearchFullTime��5U      $��	77,80,0,0q�5V      $
��Left=�5W      $	��Top=�5X      $��	Full Time��5Z      �� 5[   
   -	   5        $ Checkbox_SearchPartTime��5\      $��
160,80,0,0q�5]      $
��Left=�5^      $	��Top=�5_      $��	Part Time��5a      �� 5b   
   -
   5        $ Checkbox_SearchPast��5c      $��
245,80,0,0q�5d      $
��Left=�5e      $	��Top=�5f      $��Not current��5g      �� 5h   
   -   5        $ Checkbox_SearchCurrent��5i      $��
340,80,0,0q�5j      $
��Left=�5k      $	��Top=�5l      $��Current��5m      �� 5n   
   -   5        $ Checkbox_EnrolledNoFees��5o      $��
77,114,0,0q�5p      $
��Left=�5q      $	��Top=�5r      $6��0Students who have enrolled but not paid the fees��5s        5t   
   -   5        $��DgNavigationBar��5u      $��25��5v      $��	40,10,0,0q�5w      $��Stretch=�5x      $	��Top=�5y       .     ColumnHeaderHeight$ 0Q�5{      $��12(�5|         GridLinesVisibility$
 None=�5}         HeadersVisibility$
 None=�5~       . $ Disabled=�5�       5�        5�      $  ��6F   	 6%   �� $
 Title�6F    � LayoutTransform 5�      V� 5�      .~�5�      ��  �� Angle$ 90Q�6&   u� 5�       u� Matrix$ -1,0,0,1,0,0x�6&   5�         ColumnHeaderStyle 5�      �� 5�      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn# [B 6    �� 
TargetType"  6Q   .�5�      ��  �� Property �@�LayoutTransform �� Value 5�      V� 5�      .~�5�   "   �� $	 -90Q�62   �� 5�   "    �� ScaleX$ 1Q�61    �� ScaleY$ -1Q�6<   5�      5�      5�         	CellStyle 5�      �� 5�      *  $System.Windows.Controls.DataGridCell"  6   .�5�      ��  �@�LayoutTransform 5�      V� 5�      .~�5�   "   �� $	 -90Q�62   �� 5�   "   $ 1Q�61   $ -1Q�6<   5�      5�      5�      5�      5�      5�      