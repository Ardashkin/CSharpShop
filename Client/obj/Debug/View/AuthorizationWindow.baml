   M S B A M L   `   `   `  ����A  =Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Client.ViewClient.View  5   	   %    Client.View.AuthorizationWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Client.View     5   	     � Title$  Authorization��5   	   $	��340��6   $	��370��6,   
������� � WindowStartupLocation$ CenterScreen=�6O    � 
ResizeMode$ NoResize=�6t   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��77* �6   �� 5      $	��62* �6   �� 5      $	��62* �6   �� 5      $
��110* �6   .+�5   
   �� $��30(�6    �� Padding$ 10q�6"   $	��Top=�6/   $
��Left=�6G   $��0��6b   $��60��6o   $	��111��6{   	Sign In6�   �� 5   
   -   5         ��Name$ loginTextBox��5      $��Bottom=�6)   $��
10,0,10,10q�6E   $��1��6Y   $��30��6f   .��6�   Login6�   �� 5   
   -   5        $ PasswordTextBox��5      $��Center=�6-   $��10,11,10,19q�6I   $��2��6^   $��30��6k   .��6�   
Password6�   � 5   
   $��3��6    � ColumnDefinitions 5      �� 5      �� 5      .+�5      �� -   5         ��Name$ ButtonSignIn��5      $��Sign In��6+   $��18(�6=   $	��Top=�6K   $��0��6c   $��38��6s   $��10q�6   ���	#FF69D7F76�   �� 5      -   5        $ ButtonRegstration��5      $��Registration��60   $��18(�6G   $	��Top=�6U   $��1��6m   $��38��6}   ���	#FF69D7F7$��10q�6�   6�   5      �� 5   
   -   5        $ button��5      $��Button��6!   $
��Left=�62   $��
215,35,0,0q�6M   $	��Top=�6a   $��75��6y   6�   5      5      