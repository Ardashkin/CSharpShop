   M S B A M L   `   `   `  ����A  =Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Client.ViewClient.View  5   	   $    Client.View.RegistrationWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Client.View     5   	     � Title$  Registration��5   	   $	��456��6   $	��355��6+   
������� � WindowStartupLocation$ CenterScreen=�6N    � 
ResizeMode$ NoResize=�6s   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��Enter your information��6   $��Center=�62   $��20(�6O    �� Padding$ 5q�6]   �� 5   
   -   5         ��Name$ NameTextBox��5      $
��Name��6(   $��Bottom=�64   $��10q�6P   $��1��6\   $��32��6i   6u   �� 5   
   -   5        $ SurnameTextBox��5      $��Surname��6+   $��Bottom=�6:   $��10q�6V   $��2��6b   $��32��6o   6{   �� 5   
   -   5        $ LoginTextBox��5      $��Login��6)   $��Bottom=�66   $��10q�6R   $��3��6^   $��32��6k   6w   �� 5   
   -   5        $ PasswodTextBox��5      $��Password��6+   $��Bottom=�6;   $��10q�6W   $��4��6c   $��32��6p   6|   �� 5   
   -   5        $ PhoneTextBox��5      $��Phone��6)   $��Bottom=�66   $��10q�6R   $��5��6^   $��32��6k   6w   �� 5   
   -   5        $ AdressTextBox��5      $��Address��6*   $��Bottom=�69   $��10q�6U   $��6��6a   $��32��6n   6z   � 5   
   $��7��6    � ColumnDefinitions 5      �� 5      �� 5      .+�5       �� -   5         ��Name$ ButtonRegistrate��5       $��
Registrate��6/   $��20(�6D   $��Stretch=�6R   $��0��6n   $
��10,7q�6~   ���	#FF69D7F76�   �� 5!      -   5        $ 
ButtonBack��5!      $
��Back��6)   $��20(�68   $��Stretch=�6F   $��1��6b   $
��10,7q�6r   ���	#FF69D7F76�   5"      5#      5$      