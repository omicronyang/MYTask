<?php require_once('config/tank_config.php'); 

$getjson = file_get_contents('php://input');
$dataarr =json_decode($getjson, true);
$token=$dataarr['token'];
$taskid=$dataarr['taskid'];

$uid = check_token($token);
if($uid <> 3){

    $get_function = get_task_status( 1 );


$redata = json_encode($get_function);
echo $redata;
} else {
echo 3;
}
?>
