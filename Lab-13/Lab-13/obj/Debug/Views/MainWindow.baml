   M S B A M L   `   `   `  ����A  =Lab-13, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Lab_13Lab_13  5          Lab_13.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:Lab_13     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  Lab-13 — Банк��5      $	��525��5	      $	��350��5
      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   .+�5   
   �� $��0��5      ��5      �� *	Persons+ �� SelectedItem 5      �� *SelectedPerson+��5      �� 5      .R�5      �� .+�5      �� $��18(�6$   ��62   ��  �� Path$ FullName��� 5      ��6$   �� $ ContributionType�5      5      5       � 5"   
   $��1��6   .+�5#      �� 
���� ����5$      u� 5%       u� Bottom$ 0Q�5&       u� Left$ 2Q�5'       u� Right$ 0Q�5(      
 u� Top$ 0Q�5)      ._�5+      � .+�5,      �� $��10q�6!   	 � DataContext	 6-   �� *SelectedPerson+.+�5-      �� $��Тип вклада:��6$   �� 5.      $��25��5/      $��0,0,0,10q�50      $��Center=�51      ��52      �� *ContributionType+
 �� UpdateSourceTrigger$
 PropertyChanged=��� 54      $ ��ФИО вкладчика:��6$   �� 55      $��25��56      $��0,0,0,10q�57      $��Center=�58      ��59      �� *
FullName+$
 PropertyChanged=�5:      �� 5;      $
��auto��5<      $��25��5=      $��
35,0,35,10q�5>      $��Bottom=�5?      $��Добавить��5A      ��5@      �� *
AddCommand+5A      5B      5C      5D      5E      5F      