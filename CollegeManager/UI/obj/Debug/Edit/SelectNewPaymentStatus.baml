   M S B A M L   `   `   `  ����  View&     View.Edit.SelectNewPaymentStatus   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  Manage payments��5      $	��400��5      $	��160��5	       � WindowStartupLocation$ CenterScreen=�5
       � WindowStyle$ 
ToolWindow=�5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   $��400px��6)    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   $
��50px��6*   .+�5   
   �� $��0��5      $��0��5      $,��&Please enter in new payment details : ��5      �� 5   
   $��1��5      $��0��5      $��Amount paid: ��5      �� 5    
   -   5         ��Name$ Textbox_AmountPaid��5!      $��1��5"      $��1��5#      �� 5$   
   $��2��5%      $��0��5&      $��Amount due: ��5'      �� 5(   
   -   5        $ Textbox_AmountDue��5)      $��2��5*      $��1��5+      �� 5,   
   -   5         ��Name$ Btn_UpdatePayment��5-      $��3��5.      $��0��5/      $��2��50      $��Update payment��52      53      54      