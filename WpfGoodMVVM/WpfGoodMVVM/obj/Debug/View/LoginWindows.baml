   M S B A M L   `   `   `  ����F  BWpfGoodMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WpfGoodMVVMWpfGoodMVVM  5   	   3clr-namespace:WpfGoodMVVM.ViewWpfGoodMVVM.View  5   	   #    WpfGoodMVVM.View.LoginWindows   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (ffclr-namespace:WpfGoodMVVM     5   	   0localclr-namespace:WpfGoodMVVM.View     5   	   -   5        $��Windows��5	   -     � Title$  登录��6	   $	��450��6   $	��800��6!   .��5
      �  � RowDefinitions 5   
   �� 5      $��40 �6   6*   �� 5      $��* �6   6)   �� 5      $��90 �6   6*    � ColumnDefinitions 5   
   �� 5      $	��120 �6   6-   �� 5      $��* �6   6+   �� 5      $	��120 �6   6-   .+�5   
   �� $��0��6   $��1��6"   .+�5      �� $��30(�6   $��Center=�6&   欢迎使用查询系统6M   5      �� 5   
   $��1��6   $��1��6"   .+�5      �� $��25(�6   $��Stretch=�6&    �� Padding$
 0,10q�6D   账号6W   �� 5      -   5        $��usertext��5   "   $��60��6   ��62   �� *
UserName+6N   �� 5      $��25(�6   $��Stretch=�6&   $
 0,10q�6D   密码6W   G� 5      -   5        $��pwdtxt��5   &   $��60��6   &    WpfGoodMVVM.PasswordBoxAssistant   BindPassword .    BoundPassword 5      ��  �� Path$	 Pwd� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5      �� 5   
   $��2��6   $��1��6"   	 �� Orientation$	 
Horizontal=�62   $��Center=�6K   $��Center=�6h   .+�5       �� -   5        
 ��Name$
 login��5       $��登录��6$   $��80��61   $��40��6<   $��20(�6H   ��6V   �� *
GetLogin+�� 5!      -   5        $

 Exit��5!      $��退出��6#   $��80��60   $��40��6;   $��20(�6G   $��10q�6U   ��6a   �� *	ExitLogin+��6   ��  �� ElementName$ Windows��6�   5"      5$      5%      