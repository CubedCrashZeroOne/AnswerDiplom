   M S B A M L   `   `   `  ����N  JDiplomAnswerProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:DiplomAnswerProject.PagesDiplomAnswerProject.Pages  5      ,    &DiplomAnswerProject.Pages.SubjectsPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:DiplomAnswerProject.Pages     5        N� Title$  SubjectsPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��5* �6   �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ testDataGrid��5         AutoGenerateColumns$ False��6)      
IsReadOnly$
 True��6E   $��2��6W      DataGridStyle#���   6k      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ id��6%      
Visibility$ Hidden=�61     DataGridHeaderStyle	   HeaderStyle#	 �  6_   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6E   �� *idSub+6_     5      $ 
Назва��6%   #	 �  6P   
 64   �� *	nameSub+6P     5      $ Скорочення��6%   #	 �  6Z   
 69   �� *shortNameSub+6Z     5      $% Кількість тестів��6%   #	 �  6Y   
 6?   �� *count+6Y   5      �� 5    
   -   5         ��Name$ TestBackButton��5       $��
Назад��6)   $��1��69   $��0 20 0 0q�6F   $��48��6X   $	��191��6d     ButtonStyle#���  6�   ��6p   Z�  � 	Resources 5!       �� 
TargetType �� Property �� Value��%_   '��       �� 5"      " ��6   .�5#      ��  �@��CornerRadius$ 30��65   5$      5%      5&      �� 5'   
   -   5        $ TestOkButton��5'      $��Далі��6'   $��1��66   $��1��6C   $��0 20 0 0q�6S   $��48��6e   $	��191��6q   #���  6�   ��6}   Z�  5(      ��%_   '��       �� 5)      " ��6   .�5*      ��  �@��CornerRadius$ 30��65   5+      5,      5-      5.      5/      